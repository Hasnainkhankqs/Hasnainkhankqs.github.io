<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
        <link rel="stylesheet" href="../bootstrap-4.0.0-alpha.6/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="../bootstrap-4.0.0-alpha.6/tether-1.3.3/dist/css/tether.min.css">
    <link rel="stylesheet" href="../styles/style.css">
</head>
<body>
    <div class="row ">
        <div class="col-md-12">
    <h1 class='text-center '>Login</h1>
    <form class="form-inline" action='checkout.php' method='post'>
  <label class="sr-only" for="inlineFormInputGroup">Email</label>
  <div class="input-group mb-2 mr-sm-2 mb-sm-0">
    <div class="input-group-addon">@</div>
    <input type="email" class="form-control" id="inlineFormInputGroup"  name='email'>
  </div>
  <label class="sr-only" for="inlineFormInputGroup">Password</label>
  <div class="input-group mb-2 mr-sm-2 mb-sm-0">
    <div class="input-group-addon">***</div>
    <input type="password" class="form-control" id="inlineFormInputGroup"name='password'>
  </div>
    <a href="forget.php" class='text-danger'>Forgot Password</a><br/><br/><br/>
  <button type="submit" class="btn btn-primary btn-block" name='login'>Submit</button>
</form>
<?php 

if(isset($_POST['login'])){
   // $ip_address  = getIp();
        $ip_address  = 1;
  $user_email = $_POST['email'];
  $user_password = $_POST['password'];
  $select = "select * from customers where customer_email = '$user_email' and customer_pass = '$user_password'";
  $runquery = mysqli_query($conn,$select);
  $countaccount = mysqli_num_rows($runquery);
 $cartquery =  "select * from cart where ip_addrs= '$ip_address'";
 $runcart = mysqli_query($conn,$cartquery);
 $countcart = mysqli_num_rows($runcart);
 if($countaccount == 0){
   echo "<script>alert('password or email is not correct')</script>";
   exit();
 }
 if($countaccount == 1 AND $countcart == 0){
   $_SESSION['user_email'] = $user_email;
   echo "<script>window.open('customer/customer_account.php','_self')</script>";
 }
 else{
   $_SESSION['user_email'] = $user_email;
   include("payment_options.php");
 }

}



?>
<a href="register.php"><h2 class='text-primary'>Register Here</h2></a>
        </div>
    </div>
</html>

