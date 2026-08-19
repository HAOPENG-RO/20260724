<?php 
session_start();
require_once("../config/db.php");
if (!isset($_SESSION["linework_id"])) {
    header("Location: ../lineworks/login.php");
    exit();
}

$book_id = (int)$_GET['id'];

$sql = "SELECT * FROM books WHERE id = ?";
$stmt = $conn->prepare($sql);
$stmt->bind_param("i", $book_id);
$stmt->execute();
$result = $stmt->get_result();

if ($result->num_rows == 0) {
    echo "本が見つかりません。";
    exit();
}

$book = $result->fetch_assoc();
$message = "";

if($_SERVER["REQUEST_METHOD"] == "POST") {
    $due_date = trim($_POST['due_date']);
    if($book["status"] == "available"){
       $rent_date = date("Y-m-d");

       $sql= "insert into rentals(
       book_id,linework_id,rent_date,due_date,return_date) values
       (?,?,?,?,null)";
       $stmt = $conn->prepare($sql);
       $stmt->bind_param("isss", $book_id, $_SESSION["linework_id"], $rent_date, $due_date);

       if($stmt->execute()){
           $sql = "update books set status='borrowed' where id=?";
           $stmt = $conn->prepare($sql);
           $stmt->bind_param("i", $book_id);
           $stmt->execute();
           header("Location: scan.php");
           exit();
       }else{
        $message = "貸出処理に失敗しました。";
       }
    }
}
?>
<!DOCTYPE html>
<html lang="ja">
<head>
    <meta charset="UTF-8">
    <title>本を借りる</title>
    <link rel="stylesheet" href="../assets/css/style.css">
</head>
<body>
<div class="borrow-box">
    <h1>本の貸出</h1>
    <div class="book-info">
        <?php 
        $image = "../images/" . $book["image"];
            if(!empty($book["image"]) && file_exists($image)){
                echo "<img src='$image' alt='本の画像'>";
            }else{
                echo "<p>画像なし</p>";
            }
        ?>
        <h2>
            <?php echo htmlspecialchars($book["title"]); ?>
        </h2>

        <p>
            本ID:
            <?php echo htmlspecialchars($book["id"]); ?>
        </p>
    </div>
    <hr>
        <?php if(!empty($message)){ ?>
            <p class="error">
                <?php echo htmlspecialchars($message); ?>
            </p>
        <?php } ?>

        <h2>返却予定日</h2>
        <form method="post">
            <label for="due_date">返却予定日:</label>
            <br>
            <input type="datetime-local"id="due_date" name="due_date" required>
            <br><br>
            <button type="submit" class="btn">貸出</button>
        </form>
    
</div>
</body>
</html>

