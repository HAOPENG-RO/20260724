<?php
session_start();
require_once("../config/db.php");

$sql="select * from books order by id asc";
$result=$conn->query( $sql );
$role="user";

if(isset($_SESSION["role"])){
    $role=$_SESSION["role"];
}
?>

<!DOCTYPE html>
<html lang="ja">
    <head>
        <meta charset="UTF-8">
        <title>本一覧</title>
    </head>
    <body>
        <h1>本一覧</h1>
        <?php if($role=="admin"){ ?>
        <div class="add">
        <a href="add.php">
            <button>＋ 本を追加</button>
        </a>
        </div>
        <?php } ?>
        
    </body>
</html>



