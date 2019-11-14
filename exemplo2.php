<?php
  try {
    $conn = new PDO("mysql:host=localhost;dbname=test", "root", "");

    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  if($_REQUEST['action']=="show_clientes") {

    $sql = 'SELECT * FROM `clientes` ORDER BY `nome` ASC';
    
    foreach ($conn->query($sql) as $row) {
        echo $row['cod']."</next>";
		echo $row['nome']."</next>";
    }
    $conn = null;
}
  }
  catch(PDOException $err) {
    echo "ERROR: Unable to connect: " . $err->getMessage();
  }
?>