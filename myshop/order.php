<?php 
include("includes/db.php");
include("function/function.php");




if(isset($_GET['customer_id'])){
    $customer_id = $_GET['customer_id'];
 //  $ip_address  = getIp();
        $ip_address = 1;
        $status = "Pending";
        $invoice_no = mt_rand();
         $persum = 0;
         $total = 0;
         $totalquantity = 0;
         $viewproduct = "select * from cart where ip_addrs = '$ip_address'";
         $run = mysqli_query($conn,$viewproduct);
         $count_products = mysqli_num_rows($run);
         while($runquery = mysqli_fetch_array($run)){
             $productcart_id =  $runquery['p_id'];
             $product_qty =  $runquery['p_qty'];
             $cart_id    =  $runquery['id'];
             $totalquantity += $product_qty;
            $viewproduct2 = "select * from products where product_id = '$productcart_id'";
            $run2 = mysqli_query($conn,$viewproduct2);
             while($runquery2 = mysqli_fetch_array($run2)){
                    $product_id     =  $runquery2['product_id'];   
                    $product_title  =  $runquery2['product_title'];   
                    $product_image  =  $runquery2['product_img1'];   
                    $product_price  =  $runquery2['product_price'];
                    $persum =  $product_qty * $product_price;
                    $total = $total + $persum;
                   

}}


 $qty  = "select * from cart where ip_addrs = $ip_address";
 $runqty = mysqli_query($conn,$qty);
 $countqty  = mysqli_fetch_array($runqty);
 $rownumber = mysqli_num_rows($runqty);
 $intocustomer = "INSERT INTO `customer_orders`(`customer_id`, 
  `due_amount`, `invoice_no`, `total_products`, 
  `order_date`, `order_status`) VALUES ('$customer_id',
  '$total','$invoice_no','$rownumber',now(),'$status')";
  $runquery = mysqli_query($conn,$intocustomer);
       
   $intopending = "INSERT INTO `pending_orders`(`customer_id`,
   `invoice_no`, `product_id`, `qty`,
   `order_status`) VALUES ('$customer_id',
  '$invoice_no','$product_id','$totalquantity','$status')";
  $runquery2 = mysqli_query($conn,$intopending);


$deletecart = "delete from cart where ip_addrs = '$ip_address'";
$delete  = mysqli_query($conn,$deletecart);


}


?>