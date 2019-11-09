<?php

$conn = mysqli_connect("localhost","root","","myshop");
if(!$conn){
    die("Connection Failed" . mysqli_error());
}

?>
<form action='problem.php' method='post'>
<input type="submit" name='update' class='btn btn-primary' value='Update Cart'>
</form>
<?php


    $qty_id = 1;
    $ip_address = 1;
    $p_qty = 7;
   if(isset($_POST['update'])){
        $cartget = "select * from cart where ip_addrs = '$ip_address' && p_qty = '$qty_id'";
        $runcart = mysqli_query($conn,$cartget);
        if($runcart){
            $fetchid = mysqli_fetch_array($runcart);
            $cartid = $fetchid['id'];
            echo $cartid;
            echo "query working";
                }
        else{
            echo "query not working";  
            }
}


?>