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
.cartfun{
    background:lightslategray;
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
    <?php cart(); ?>
    <div class="col-md-9 paddingMarginOff">
        <div class="row">
            <article class="col-md-12 text-center paddingMarginOff">
               <div class="row">
        <div class="col-md-12">
    <h1 class='text-center '>Register</h1>
    <form  action='register.php' method='post' enctype='multipart/form-data'>
 <div class="form-group row">
  <label for="example-text-input" class="col-2 col-form-label">Name</label>
  <div class="col-10">
    <input class="form-control" type="text" name='name'>
  </div>
</div>
<div class="form-group row">
  <label for="example-email-input" class="col-2 col-form-label">Email</label>
  <div class="col-10">
    <input class="form-control" type="email" name='email'>
  </div>
</div>
<div class="form-group row">
  <label for="example-search-input" class="col-2 col-form-label">password</label>
  <div class="col-10">
    <input class="form-control" type="password" name='password'>
  </div>
</div>
<div class="form-group row">
  <label for="example-url-input" class="col-2 col-form-label">Country</label>
  <div class="col-10">
    <input class="form-control" type="text" name='country'>
  </div>
</div>
<div class="form-group row">
  <label for="example-tel-input" class="col-2 col-form-label">City</label>
  <div class="col-10">
    <input class="form-control" type="text" name='city'>
  </div>
</div>
<div class="form-group row">
  <label for="example-password-input" class="col-2 col-form-label">Contact</label>
  <div class="col-10">
    <input class="form-control" type="text" name='contact'>
  </div>
</div>
<div class="form-group row">
  <label  class="col-2 col-form-label">Image</label>
  <div class="col-10">
    <div class="container">
<div class="col-md-6">
    <div class="form-group">
        <div class="input-group">
            <span class="input-group-btn">
                <span class="btn btn-warning btn-file">
                    Browse… <input type="file" id="imgInp" name='img'>
                </span>
            </span>
            <input type="text" class="form-control" readonly>
        </div>
        <img id='img-upload'/>
    </div>
</div>
</div>

  </div>
</div>



<div class="form-group row">
  <label for="example-number-input" class="col-2 col-form-label">Address</label>
  <div class="col-10">
    <textarea class="form-control"  name='address'></textarea>
  </div>
</div>
<input type="submit" name='submit'  class="form-control btn btn-success">         
</form>
<?php 
include('includes/db.php');
if(isset($_POST['submit'])){
  $name = $_POST['name'];
  $email = $_POST['email'];
  $password = $_POST['password'];
  $country = $_POST['country'];
  $city = $_POST['city'];
  $contact = $_POST['contact'];
  $address = $_POST['address'];
  $image = $_FILES['img']['name'];
  $temp_img = $_FILES['img']['tmp_name'];
move_uploaded_file($temp_img,'customer/img/'.$image);
 // $ip_address  = getIp();
        $ip_address  = 1;
  $inserquery = "INSERT INTO `customers`
  (`customer_name`, `customer_email`,
   `customer_pass`, `customer_country`, `customer_city`,
    `customer_contact`, `customer_address`,`customer_img`,`customer_ip`) VALUES ('$name',
    '$email','$password','$country','$city','$contact','$address','$image','$ip_address')";
    $runinsert = mysqli_query($conn,$inserquery);
    $cartquery = "select * from cart where ip_addrs = '$ip_address'";
    $cartview = mysqli_query($conn,$cartquery);
    $num  = mysqli_num_rows($cartview);
    if($num > 0){
      $_SESSION['user_email'] = $email;
      echo "<script>window.open('checkout.php','_self')</script>";
    }
    else{
      $_SESSION['user_email'] = $email;
      echo "<script>window.open('index.php','_self')</script>";
    }

}



?>
<a href="checkout.php">Login Here</a>
        </div>
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


      <script src="jquery-3.2.1.min.js"></script>
    <script src="bootstrap-4.0.0-alpha.6/dist/js/bootstrap.min.js"></script>
    <script src="bootstrap-4.0.0-alpha.6/tether-1.3.3/dist/js/tether.min.js"></script>
    <script src="js/app.js"></script>

</body>

</html>
    