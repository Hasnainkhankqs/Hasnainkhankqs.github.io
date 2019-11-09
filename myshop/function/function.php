<?php 
// include('../includes/db.php');
$conn = mysqli_connect("localhost","root","","myshop");
if(!$conn){
    die("Connection Failed" . mysqli_error());
}


// view random products
function viewproduct(){
    global $conn;
    if(!isset($_GET["cat_id"])){
        if(!isset($_GET["brand_id"])){

    $displayProduct = "SELECT * FROM `products` ORDER by rand() LIMIT 0,6";
    $run = mysqli_query($conn,$displayProduct);
                       
                            while($row = mysqli_fetch_array($run)){
                                $product_id = $row['product_id'];
                                $product_title = $row['product_title'];
                                $product_img1 = $row['product_img1'];
                                $product_price = $row['product_price'];
                            echo "<div class='col-md-3 product_thumbnail'>
                        <figure class='figure'>
                            <figcaption class='figure-caption'> $product_title </figcaption>
                                <img src='admin_area/product_images/$product_img1' class='figure-img img-fluid  img-thumbnail' alt='A generic square placeholder image with rounded corners in a figure.'>
                                <div>Price:<span>$ $product_price</span></div>
                                <div>
                                    <a href='detail.php?detail=$product_id' class='btn btn-primary btn-sm' >detail</a>
                                    <a href='index.php?cart=$product_id' class='btn btn-success btn-sm' >Add Card</a>
                                </div>
                        </figure>
                    </div>";
                        
                }
                    
        }
    }
}
// view brandlist
function brandlist(){
    global $conn;
     $query = mysqli_query($conn,"select * from brand");

                while($row = mysqli_fetch_array($query)){
                        $brand_id  = $row['brand_id'];
                        $brand_title  = $row['brand_title'];
                echo "<li><a href='index.php?brand_id=$brand_id'> $brand_title </a></li>";
                }
}
// view category list
function catList(){
    global $conn;
    $query = mysqli_query($conn,"select * from categories");

                while($row = mysqli_fetch_array($query)){
                ?>

                     <li><a href="index.php?cat_id=<?php echo $row['cat_id'];?>"><?php echo $row['cat_title']?></a></li>
                <?php
                }
}



// view  products by categoy
function category(){
     global $conn;
    if(isset($_GET['cat_id'])){
    $cat_id = $_GET["cat_id"];
    $displayProduct = "SELECT * FROM `products` where cat_id = $cat_id";
    $run = mysqli_query($conn,$displayProduct);
    $count = mysqli_num_rows($run);
    
    if($count == 0){
    echo "<h3>Product Not Available right now !!!</h3>";
    }                       
        else{
                            while($row = mysqli_fetch_array($run)){
                                $product_id = $row['product_id'];
                                $product_title = $row['product_title'];
                                $product_img1 = $row['product_img1'];
                                $product_price = $row['product_price'];
                            echo "<div class='col-md-3 product_thumbnail'>
                        <figure class='figure'>
                            <figcaption class='figure-caption'> $product_title </figcaption>
                                <img src='admin_area/product_images/$product_img1' class='figure-img img-fluid  img-thumbnail' alt='A generic square placeholder image with rounded corners in a figure.'>
                                <div>Price:<span>$ $product_price</span></div>
                                <div> 
                                    <a href='detail.php?detail=$product_id' class='btn btn-primary btn-sm' >detail</a>
                                    <a href='index.php?cart=$product_id' class='btn btn-success btn-sm' >Add Card</a>
                                </div>
                        </figure>
                    </div>
                    "
                    ;
                        }
                }
            }
}
                    
// view  products by brand
function brand(){
     global $conn;
    if(isset($_GET['brand_id'])){
    $brand_id = $_GET["brand_id"];
    $displayProduct = "SELECT * FROM `products` where brand_id = $brand_id";
    $run = mysqli_query($conn,$displayProduct);
    $count = mysqli_num_rows($run);
    if($count == 0){
        echo" <h3>Product Not Available right now !!!</h3>";
    }
                        else{
                            while($row = mysqli_fetch_array($run)){
                                $product_id = $row['product_id'];
                                $product_title = $row['product_title'];
                                $product_img1 = $row['product_img1'];
                                $product_price = $row['product_price'];
                            echo "<div class='col-md-3 product_thumbnail'>
                        <figure class='figure'>
                            <figcaption class='figure-caption'> $product_title </figcaption>
                                <img src='admin_area/product_images/$product_img1' class='figure-img img-fluid  img-thumbnail' alt='A generic square placeholder image with rounded corners in a figure.'>
                                <div>Price:<span>$ $product_price</span></div>
                                <div>
                                    <a href='detail.php?detail=$product_id' class='btn btn-primary btn-sm' >detail</a>
                                    <a href='index.php?cart=$product_id' class='btn btn-success btn-sm' >Add Card</a>
                                </div>
                        </figure>
                    </div>";
                        }
                }
                }
                    
}
// get ip
function getIp(){
    if (!empty($_SERVER['HTTP_CLIENT_IP'])) {
    $ip = $_SERVER['HTTP_CLIENT_IP'];
} elseif (!empty($_SERVER['HTTP_X_FORWARDED_FOR'])) {
    $ip = $_SERVER['HTTP_X_FORWARDED_FOR'];
} else {
    $ip = $_SERVER['REMOTE_ADDR'];
}
return $ip;
}
// add to cart

function cart(){
    global $conn;
    if(isset($_GET['cart'])){
        // $ip_address  = getIp();
        $ip_address  = 1;
        $product_id  = $_GET['cart'];
        $check_double_click = "select * from cart where ip_addrs = '$ip_address' and p_id = '$product_id'";
        $check_double_click = mysqli_query($conn,$check_double_click);
        if(mysqli_num_rows($check_double_click) > 0 ){
            echo "<script>alert('Only on time click allowed');
             window.open('index.php','_self')</script>";
        }
        else{
            $insert_data = "insert into cart (p_id,ip_addrs,p_qty) VALUES ('$product_id','$ip_address',1)";
            $insert_data = mysqli_query($conn,$insert_data);
            echo "<script>window.open('index.php','_self')</script>";
        }
    }
}


// get item quantity
function itemsum(){
    if(isset($_GET['cart'])){
        global $conn;
        // $ip_address  = getIp();
        $ip_address  = 1;
        $query = "select * from cart where ip_addrs = $ip_address";
        $run = mysqli_query($conn,$query);
        $count  = mysqli_num_rows($run);
    }
    else{
         global $conn;
        //  $ip_address  = getIp();
        $ip_address  = 1;
        $query2 = "select * from cart where ip_addrs = $ip_address";
        $run2 = mysqli_query($conn,$query2);
        $count  = mysqli_num_rows($run2);
    }
    echo $count;
    
}


function totalqty()
{
    global $conn;
          // $ip_address  = getIp();
        $ip_address  = 1;
        $count = 0;
        $query = "select * from cart where ip_addrs = $ip_address";
        $run = mysqli_query($conn,$query);
        while($runquery = mysqli_fetch_array($run)){
            $count += $runquery['p_qty'];
        }

    echo $count;
    
}

// total price
function totalprice()
{
    global $conn;
    //  $ip_address  = getIp();
        $ip_address = 1;
        $total = 0 ;
        $sel_price = "select * from cart where ip_addrs = '$ip_address'";
        $run_query = mysqli_query($conn,$sel_price);
            while($row = mysqli_fetch_array($run_query)){
               $product_id =  $row['p_id'];
               $product_qty =  $row['p_qty'];
               $persum = 0;
               $query2 = "select * from products where product_id = '$product_id' ";
               $run_query2 = mysqli_query($conn,$query2);
               while($nestedrow = mysqli_fetch_array($run_query2)){
                //    $product_price = array($nestedrow['product_price']);
                //    $arraySum = array_sum($product_price);
                //    $total +=  $arraySum;
                    $persum = $product_qty*$nestedrow['product_price'];
                   $total += $persum;

               }
            }
            echo $total;
}
?>