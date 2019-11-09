<?php 
session_start();
if($_SESSION['user_email'] == ''){
    header('location:../index.php');
}
include('../includes/db.php');
include('function/function.php');


?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="../bootstrap-4.0.0-alpha.6/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="../bootstrap-4.0.0-alpha.6/tether-1.3.3/dist/css/tether.min.css">
    <link rel="stylesheet" href="../styles/style.css">

    <title>My Shop</title>
    <style>
.cartfun{
    background:lightslategray;
}
    </style>
</head>

<body>

    <div class="container-fluid">

        <header class="text-center">
            <div class="col-md-1 col-sm-1">
                <img src="../images/img1.png" alt="" class="img-fluid">
            </div>
            <div class="col-md-4 col-sm-4">
                <img src="../images/img2.png" alt="" class="img-fluid">
            </div>
            <div class="col-md-3 col-sm-3">
                <img src="../images/img3.jpg" alt="" class="img-fluid">
            </div>
            <div class="col-md-3 col-sm-3">
                <img src="../images/img4.gif" alt="" class="img-fluid">
            </div>
        </header>
        <nav class="navbar navbar-toggleable-sm navbar-inverse bg-inverse">
  <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="../index.php">Home <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="../all_products.php">All Products</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="customer_account.php">My Account</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="../cart.php">Sopping Cart</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="../contactus.php">Contact Us</a>
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

    echo $_SESSION['user_email'] .' ! ';



?>
 </span>
 
  -Total item <?php totalqty() ?>-Total price : $ .<?php totalprice() ;?> -- <a href='cart.php'>Goto Cart</a><b>
<?php 
if(isset($_SESSION['user_email'])){
    ?>
<a href='<?php echo "../logout.php" ?>' class='text-warning'><?php echo "Logout" ?></a></b>
<?php
}
else
{
    ?>
    <a href='<?php echo "../checkout.php" ?>' class='text-warning'><?php echo "Login"?></a></b>
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
                
            <h1>Mannage Account</h1>
            <ul class='paddingMarginOff' style='list-style:none'>
                <?php 
                    $user_email = $_SESSION['user_email'];
                    echo $user_email;
                ?>
                <li><a href="edit_account.php">My Orders</a></li>
                <li><a href="edit_account.php">Edit Account</a></li>
                <li><a href="edit_account.php">Change Password</a></li>
                <li><a href="edit_account.php">Delete Account</a></li>
                <li><a href="<?php echo '../logout.php' ?>">Logout</a></li>
            </ul>
           
        </div>
        </div>
        <div class'row'>
            <div class="col-md-12 text-center" >
            <h1>Brands</h1>
            <ul class='paddingMarginOff' style='list-style:none'>
                <?php 
               
                ?>
                
            </ul>
        </div>
        </div>
         </aside>
    <?php cart(); ?>
    <div class="col-md-9 paddingMarginOff">
        <div class="row">
            <article class="col-md-12 text-center paddingMarginOff">
                <div class="row">
                        <div class='bg-primary col-md-12 text-center'>
                            <h2>Manage Your Account Here</h2>
                        </div>
                    <?php 
                     
                    ?>
                    
                </div>
            </article>
        </div>
    </div>
</div>
<div class="row">
    
</div>
<footer class="text-center" style="background-color:lightslategray;">
   
        This is made by Hasnain Khan kqs
   
</footer>
    </div>


    <script src="../jquery-3.2.1.min.js"></script>
    <script src="../bootstrap-4.0.0-alpha.6/dist/js/bootstrap.min.js"></script>
    <script src="../bootstrap-4.0.0-alpha.6/tether-1.3.3/dist/js/tether.min.js"></script>
    <script src="../js/app.js"></script>

</body>

</html>