<?php
    session_start();
    require_once("../config/db.php");

    $sql = "SELECT * FROM books ORDER BY id ASC";
    $result = $conn->query($sql);
    $role = "user";

    if (isset($_SESSION['role'])) {
        $role = $_SESSION['role'];
    }
?>

<!DOCTYPE html>
<html lang="ja">

<head>
    <meta charset="UTF-8">
    <title>本一覧</title>
    <link rel="stylesheet" href="../assets/css/style.css">
</head>

<body>
    <div class="container">
    <h1>本一覧</h1>
    <?php if($role=="admin"){ ?>
    <div class="add">
        <a href="add.php">
            <button>＋ 本を追加</button>
        </a>
    </div>
    <?php } ?>
    <?php if($result->num_rows>0){ ?>
        <div class="book-grid">
            <?php while($book=$result->fetch_assoc()){ ?>
                <div class="book">
                    <?php
                        $image = "../images/" . $book['image'];
                        if (!empty($book['image']) && file_exists($image)) {
                            echo "<img src='$image' alt='本の画像'>";
                        } else {
                            echo "<p>画像なし</p>";
                        }
                    ?>

                    <div class="info">
                        <h2><?php echo htmlspecialchars($book['title']); ?></h2>
                        <?php
                            if($book['status']=="available"){
                                echo "<p class='status available'>貸出可能</p>";
                            }else{
                                echo "<p class='status borrowed'>貸出中</p>";
                            }
                        ?>
                    </div>

                    <?php if($role=="admin"){ ?>
                        <div class="admin-buttons">
                            <a href="edit.php?id=<?php echo $book['id']; ?>">
                                <button>編集</button>
                            </a>
                            <a href="delete.php?id=<?php echo $book['id']; ?>"
                                onclick="return confirm('削除しますか？')">
                                <button>削除</button>
                            </a>
                        </div>
                    <?php } ?>
                </div>
            <?php } ?>
        </div>
        <?php }else{
            echo "<p>本が登録されていません。</p>";
        }
        $conn->close();
        ?>
    </div>
</body>
</html>