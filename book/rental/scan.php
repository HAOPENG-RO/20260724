<?php
session_start();
require_once("../config/db.php");
$book=null;
$message = "";
if ($_SERVER["REQUEST_METHOD"]=="POST") {

    $book_id=trim($_POST['book_id']);

    $sql = "SELECT * FROM books WHERE id = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("i", $book_id);
    $stmt->execute();
    $result = $stmt->get_result();

    if ($result->num_rows > 0) {
        $book = $result->fetch_assoc();
    } else {
        $message = "本が見つかりません。";
    }
}
?>

<!DOCTYPE html>
<html lang="ja">
<head>
    <meta charset="UTF-8">
    <title>QRコード読取</title>
    <link rel="stylesheet" href="../assets/css/style.css">
</head>
<body>

    <div class="scan-box">
        <h1>QRコード読取</h1>
        
        <form method="post">
            <input
                type="text"
                name="book_id"
                placeholder="本のID"
                min="1"
                required
            >
            <br><br>

            <button class="btn" type="submit">
                読み取る
            </button>
        </form>
        <br>
        <p class="error">
            <?php echo htmlspecialchars($message); ?>
        </p>
    <?php if ($book!=null){ ?>
        <div class="book-result">
            <?php 
            $image = "../images/" . $book["image"];
            if(!empty($book["image"]) && file_exists($image)){
                echo "<img src='$image' alt='本の画像'>";
            }else{
                echo "<p>画像なし</p>";
            }
            ?>
            <h2><?php echo htmlspecialchars($book["title"]); ?></h2>
            <p>
                本ID:
                <?php echo htmlspecialchars($book["id"]); ?>
            </p>

            <?php if ($book["status"]=="available"){ ?>
                <p class="status available">貸出可能</p>
                <a href="borrow.php?id=<?php echo $book["id"]; ?>">
                    <button class="btn">貸出</button>
                </a>
            <?php } else{?>
                <p class="status unavailable">貸出中</p>
            <?php } ?>
        </div>
    <?php } ?>
    </div>
</body>
</html>

