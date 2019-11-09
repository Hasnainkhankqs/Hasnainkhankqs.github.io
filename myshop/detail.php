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
 


 Shoping cart -Total item <?php totalqty() ?>-Total price : $ .<?php totalprice() ;?>-- <a href='goto.php'>Goto Cart</a><b>
<?php 
if(isset($_SESSION['user_email'])){
    ?>
<a href='<?php echo "logout.php" ?>' class='text-warning'><?php echo "Logout" ?></a></b>
<?php
}
else
{
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
        <div class="row">
            <article class="col-md-12 text-center paddingMarginOff">
                <div class="row">
                    <?php 
                                    
    if(isset($_GET['detail'])){
    $detail = $_GET["detail"];
    $displayProduct = "SELECT * FROM `products` where product_id = $detail";
    $run = mysqli_query($conn,$displayProduct);
       
      
                            while($row = mysqli_fetch_array($run)){
                                $product_id = $row['product_id'];
                                $product_title = $row['product_title'];
                                $product_img1 = $row['product_img1'];
                                $product_img2 = $row['product_img2'];
                                $product_img3 = $row['product_img3'];
                                $product_price = $row['product_price'];
                                $product_desc = $row['product_desc'];
                                $product_key = $row['product_key'];
                                $status = $row['status'];
                                $brand_id = $row['brand_id'];
                                // echo $brand_id;
                                //  $query2 = 'select *  from brand where brand_id = $brand_id';
                                // $run = mysqli_query($conn,$query2);
                                // $result = mysqli_fetch_array($run);
                                // $brand_title = $result['brand_title'];
?>
                        <div class='col-md-4 product_thumbnail '>
                        <figure class='figure'>
                                <img src='admin_area/product_images/<?php echo $product_img1 ?>'  class='figure-img img-fluid  img-thumbnail' alt='A generic square placeholder image with rounded corners in a figure.'>
                                <div>
                                    <a href='index.php?cart=<?php echo $product_id?>' class='btn btn-success btn-md' >Add Card</a>
                                </div>
                        </figure>
                    </div>
    
                    <div class='col-md-5 details'>
                        <div class='row'>
                            <div class='col-md-6'>
                                Product Title:
                            </div>
                            <div class='col-md-6'>
                             <?php echo $product_title ?>
                            </div>
                        </div>
                        <div class='row'>
                            <div class='col-md-6'>
                                Product Description:
                            </div>
                            <div class='col-md-6'>
                                 <?php echo $product_desc?>
                            </div>
                        </div>
                        <div class='row'>
                            <div class='col-md-6'>
                                Product price:
                            </div>
                            <div class='col-md-6'>
                              <?php echo "$ ". $product_price ?>
                            </div>
                        </div>
                        <div class='row'>
                            <div class='col-md-6'>
                                Product Keyword:
                            </div>
                            <div class='col-md-6'>
                                <?php echo $product_key ?>
                            </div>
                        </div>
                        <div class='row'>
                            <div class='col-md-6'>
                                Status:
                            </div>
                            <div class='col-md-6'>
                                <?php
                                 if($status == 1){

                                     echo "Available";
                                 }
                                 else{
                                     echo "Not Available";
                                 }
                                 ?>
                            </div>
                        </div>
                    </div>
                    
                    
                <?php
                        }
                
            }
                    ?>
                    
                <div class="row below">
                    <div class="col-md-4">
                        <img src='admin_area/product_images/<?php echo $product_img1 ?>'  class='figure-img img-fluid  img-thumbnail' alt='A generic square placeholder image with rounded corners in a figure.'>
                    </div>
                    <div class="col-md-4">
                        <img src='admin_area/product_images/<?php echo $product_img2 ?>'  class='figure-img img-fluid  img-thumbnail' alt='A generic square placeholder image with rounded corners in a figure.'>
                    </div>
                    <div class="col-md-4">
                        <img src='admin_area/product_images/<?php echo $product_img3 ?>'  class='figure-img img-fluid  img-thumbnail' alt='A generic square placeholder image with rounded corners in a figure.'>
                    </div>
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
