<?php

$conn = mysqli_connect("localhost","root","","myshop");
if(!$conn){
    die("Connection Failed" . mysqli_error());
}

?>
<script>
console.log("database file calling");
</script>