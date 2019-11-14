<?php
mysql_connect("localhost","root","");
mysql_select_db("teste1");
if($_REQUEST['action']=="show_clientes") {
$query = "SELECT * FROM `clientes` ORDER BY `cliente` ASC";
$result = mysql_query($query);
while($array = mysql_fetch_array($result)) {
echo $array['cod_cliente']."</next>";
echo $array['cliente']."</next>";
}
}
if($_REQUEST['action']=="submit_cliente") {
$name = $_REQUEST['cod_cliente'];
$score = $_REQUEST['cliente'];
$query = "INSERT INTO `clientes` (`cod_cliente`,`cliente`) VALUES ('$name','$score')";
mysql_query($query);
}
?>