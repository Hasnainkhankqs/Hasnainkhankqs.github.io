<?php 
session_start();
include('includes/db.php');
include('function/function.php');

?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="bootstrap-4.0.0-alpha.6/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="bootstrap-4.0.0-alpha.6/tether-1.3.3/dist/css/tether.min.css">
    <link rel="stylesheet" href="styles/style.css">
    <title>My Shop</title>
    <style>

.figure{
    padding-top:10px;
}
.figure img{
    height:80%;
}
.figure a {
    margin-top:50px;
}
.details{
    
    margin-top:50px;
}
.details .row{
    border-top:1px solid gray;
}
.below{
    margin-top:50px;
}
.cartfun{
    background:lightslategray;
}
.cart_img{
    width:50%;
    border:1px solid lightslategray;
    margin:10px;    
    
}
.strip{
    background-color:#80cac5;
    border-bottom:1px dotted black;
}
.margin-top{
    margin-top:30px;
}
</style>
</head>

<body>

    <div class="container-fluid">

        <header class="text-center">
            <div class="col-md-1 col-sm-1">
                <img src="images/img1.png" alt="" class="img-fluid">
            </div>
            <div class="col-md-4 col-sm-4">
                <img src="images/img2.png" alt="" class="img-fluid">
            </div>
            <div class="col-md-3 col-sm-3">
                <img src="images/img3.jpg" alt="" class="img-fluid">
            </div>
            <div class="col-md-3 col-sm-3">
                <img src="images/img4.gif" alt="" class="img-fluid">
            </div>
        </header>
        <nav class="navbar navbar-toggleable-sm navbar-inverse bg-inverse">
  <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="index.php">Home <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="all_products.php">All Products</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="customer/customer_account.php">My Account</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="cart.php">Sopping Cart</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="contactus.php">Contact Us</a>
      </li>
    </ul>
    <form class="form-inline my-2 my-lg-0" method='get' action='result.php' enctype='multipart/form-data'>
      <input class="form-control mr-sm-2" type="text" placeholder="Search" name='user_query'>
      <button class="btn btn-outline-success my-2 my-sm-0" type="submit" name='search'>Search</button>
    </form>
  </div>
</nav>
<div class="row cartfun">
<div class='col-md-12 text-right'>
<h5>Welcome
<span style='color:lightblue'>
<?php 
if(isset($_SESSION['user_email'])){
    echo $_SESSION['user_email'] .' ! your';
}
else{
    echo  " Guest ! ";
}


?>
 </span>
 





Shoping cart -Total item <?php totalqty() ?>-Total price : $ .<?php totalprice() ;?> -- <a href='cart.php'>Goto Cart</a><b>
<?php 
if(isset($_SESSION['user_email'])){
    ?>
<a href='<?php echo "logout.php" ?>' class='text-warning'><?php echo "Logout" ?></a></b>
<?php
}
else{
    ?>
    <a href='<?php echo "checkout.php" ?>' class='text-warning'><?php echo "Login"?></a></b>
<?php
}
?>
</h5>
</div> 
</div>
<div class="row">
    
        <aside class="col-md-3">
        <div class'row'>
            <div class="col-md-12 text-center" >
                
            <h1>Categories</h1>
            <ul class='paddingMarginOff' style='list-style:none'>
                <?php 
                catList();                
                ?>
            </ul>
           
        </div>
        </div>
        <div class'row'>
            <div class="col-md-12 text-center" >
            <h1>Brands</h1>
            <ul class='paddingMarginOff' style='list-style:none'>
                <?php 
                brandlist();
                ?>
                
            </ul>
        </div>
        </div>
         </aside>
    <div class="col-md-9 paddingMarginOff">
    <form action='cart.php' method='post' multipart='form-data'>
        <div class="row">
            <div class="col-md-1">
              <span>Remove</span>
            </div>
            <div class="col-md-3">
               <span>Item(s)</span>
            </div>
            <div class="col-md-3">
               <span>Quantity</span>
            </div>
            <div class="col-md-3">
               <span>One</span>
            </div>
            <div class="col-md-2">
               <span>Total Price</span>
            </div>
        </div>
        <?php 
        //  $ip_address  = getIp();
        $ip_address = 1;
         $viewproduct = "select * from cart where ip_addrs = '$ip_address'";
         $run = mysqli_query($conn,$viewproduct);
         while($runquery = mysqli_fetch_array($run)){
             $productcart_id =  $runquery['p_id'];
             $product_qty =  $runquery['p_qty'];
             $cart_id    =  $runquery['id'];
             $persum = 0;
            $viewproduct2 = "select * from products where product_id = '$productcart_id'";
            $run2 = mysqli_query($conn,$viewproduct2);
             while($runquery2 = mysqli_fetch_array($run2)){
                    $product_id     =  $runquery2['product_id'];   
                    $product_title  =  $runquery2['product_title'];   
                    $product_image  =  $runquery2['product_img1'];   
                    $product_price  =  $runquery2['product_price'];
                    $persum =  $product_qty* $product_price;
                   
        ?>
        <div class="row strip">
            <div class="col-md-1">
                <input type="checkbox" name="remove[]" class="form-control margin-top" value='<?php echo $product_id ?>'>
            </div>
            <div class="col-md-3">
               <img src="admin_area/product_images/<?php echo $product_image ?>" class='img-fluid cart_img img-thumbnail margin-top' alt="">
            </div>

            <div class="col-md-3">
                <input type="number" min='0' name='qty' class="form-control margin-top">
            </div>
            <?php 
                //  $ip_address  = getIp();
         $ip_address = 1;
        if(isset($_POST['update'])){
            $qty_id = $_POST['qty'];
           if($qty_id !== '' ){
               if( $qty_id > 0){
            $updatequery = "update cart set p_qty = '$qty_id' where ip_addrs = '$ip_address'";
            $update_run = mysqli_query($conn,$updatequery);
            if($update_run){
                echo "<script>alert('updated')</script>";
                // echo "<script>window.open('cart.php','_self')</script>";
                $persum = $product_qty * $product_price;
            }
            else{
                echo "<script>alert('not updated')</script>";
          }}
 }}   
         
 ?>
            <div class="col-md-3">
               <span class='margin-top'><?php echo '$' . $product_price ?></span>
            </div>
            <div class="col-md-2">
               <span class='margin-top'><?php echo '$' . $persum ?></span>
            </div>
        </div>
        <?php 
        
             }}
        
        ?>
         <div class="row">
            <div class="col-md-2">
              <input type="submit" name='delete' class='btn btn-primary' value='Delete Cart'>
            </div>
            <div class="col-md-2">
              <input type="submit" name='update' class='btn btn-primary' value='Update Cart'>
            </div>
            <div class="col-md-3">
              <input type="submit" name='continue'class='btn btn-primary' value='Continue Shopping'>
            </div>
            <div class="col-md-2">
               <span><a href="checkout.php">Check Out</a></span>
            </div>
            <div class="col-md-3">
               <span>Total Price : <?php  echo '$'.totalprice() ?> </span>
            </div>
<?php 

if(isset($_POST['continue'])){
    echo "<script>window.open('index.php','_self')</script>";
}


?>
        </div>
    </div>
</div>

</form>













<?php 
    $qty_id = 1;
    $ip_address = 1;
    $p_qty = 7;
    if($qty_id == 1){
        $cartget = "select * from cart where ip_addrs = '$ip_address' && p_qty = '$qty_id'";
        $runcart = mysqli_query($conn,$cartget);
        if($runcart){
            $fetchid = mysqli_fetch_array($runcart);
            echo $fetchid['id'];
            echo "<script>console.log('query working')</script>";
                }
        else{
            echo "<script>console.log('query not working')</script>";  
                }}



?>
             
             
             
             



             
             
             
             <?php
            
            
             $ip_address  = getIp();
        $ip_address = 1;
           if(isset($_POST['delete'])){
               
               foreach($_POST['remove'] as $remove_id){
              
            $deletequery = "delete from cart where p_id = '$remove_id' and ip_addrs = '$ip_address'";
            $delete_run = mysqli_query($conn,$deletequery);
            if($delete_run){
                echo "<script>window.open('cart.php','_self')</script>";
            }

}}
           
            ?>
            
<footer class="text-center" style="background-color:lightslategray;">
   
        This is made by Hasnain Khan kqs
   
</footer>
    </div>


     <script src="jquery-3.2.1.min.js"></script>
    <script src="bootstrap-4.0.0-alpha.6/dist/js/bootstrap.min.js"></script>
    <script src="bootstrap-4.0.0-alpha.6/tether-1.3.3/dist/js/tether.min.js"></script>
    <script src="js/app.js"></script>

</body>

</html>
 