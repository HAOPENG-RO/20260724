<?php
    session_start();
    require_once("../config/db.php");
    $message = "";
    if ($_SERVER["REQUEST_METHOD"]=="POST") {
        $linework_id = trim($_POST['linework_id']);
        $name = trim($_POST['name']);

        $sql = "SELECT * FROM users WHERE linework_id = ? AND name = ?";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("ss", $linework_id, $name);
        $stmt->execute();
        $result = $stmt->get_result();
        if ($result->num_rows > 0) {
            $user = $result->fetch_assoc();
            $_SESSION['linework_id'] = $user['linework_id'];
            $_SESSION['name'] = $user['name'];
            $_SESSION['role'] = $user['role'];

            if(isset($_SESSION["login_from"])){
               if($_SESSION["login_from"]=="scan"){
                  unset($_SESSION["login_from"]);
                  header("Location: ../rental/scan.php");
                  exit();
               }

               if($_SESSION["login_from"]=="list"){
                  unset($_SESSION["login_from"]);
                  header("Location: ../books/list.php");
                  exit();
               }
            }
            header("Location: ../books/list.php");
            exit();
        } else {
            $message = "ログイン情報が正しくありません。";
        }
    }

?>
<!DOCTYPE html>
<html lang="ja">

<head>
    <meta charset="UTF-8">
    <title>ログイン</title>
    <link rel="stylesheet" href="../assets/css/style.css">
</head>

<body>
    <div class="login-box">
        <h1>本管理システム</h1>
        <h2>ログイン</h2>
        <form method="POST">
            <p>LineWork ID</p>
            <input type="text" name="linework_id" placeholder="LINE WORKS ID" required>
            <p>Name</p>
            <input type="text" name="name" placeholder="名前" required>
            <button type="submit" class="btn">ログイン</button>
        </form>
        <?php if (!empty($message)) { ?>
            <p style="color:red">
                <?php echo htmlspecialchars($message); ?>
            </p>
        <?php } ?>
    </div>
</body>

</html>
