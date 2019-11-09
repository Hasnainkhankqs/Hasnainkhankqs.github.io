<?php
include('../includes/db.php');
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
     <form action="check.php" method='post'>
            <input type="text" name="product_title" value=''>
  
 <button name="insertProduct">Submit</button>
    
    </form>
</body>
</html>
<?php 

if(isset($_POST['insertProduct'])){
    $product_title         = $_POST['product_title'];
    if($product_title == ''){
    //   echo "<script>alert('Please fill all the fields')</scipt>";
     echo "<script>";
   echo "alert('Please Fill Form');";
   echo "</script>";
      exit();
    }
}

?>