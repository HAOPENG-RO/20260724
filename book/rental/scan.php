<?php
require_once("../config/db.php");
$message = "";
if (isset($_POST['qr_code'])) {

    $qr_code = trim($_POST['qr_code']);

    $sql = "SELECT * FROM books WHERE qr_code = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("s", $qr_code);
    $stmt->execute();
    $result = $stmt->get_result();

    if ($result->num_rows > 0) {
        $book = $result->fetch_assoc();
        if ($book['status'] == "available") {
            header("Location: borrow.php?id=" . $book['id']);
            exit();
        } else {
            header("Location: return.php?id=" . $book['id']);
            exit();
        }
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
                name="qr_code"
                placeholder="QRコード"
                autofocus
                required
            >
            <br><br>

            <button class="btn" type="submit">
                読み取る
            </button>
        </form>
        <br>
        <p class="error">
        <?php echo $message; ?>
    </p>
    </div>
</body>
</html>

