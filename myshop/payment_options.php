<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <h1 class='col-md-12'>Payment options</h1>

<div class='col-md-6'>
<p>Pay with Paypal <a href='#' class='btn btn-primary'>paypal</a></p>
</div>
<div class='col-md-6'>
<?php 
  //  $ip_address  = getIp();
        $ip_address = 1;
 $selectid = "select * from customers where customer_ip = '$ip_address'";
 $run = mysqli_query($conn,$selectid);
    $customer_id  = mysqli_fetch_array($run);
    $id =     $customer_id['customer_id']

?>
<p>Pay Offline <a href='order.php?customer_id=<?php echo $id; ?>' class='btn btn-warning'>Offline</a></p>
</div>
</body>
</html>