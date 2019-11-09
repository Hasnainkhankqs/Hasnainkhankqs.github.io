<?php
include('../includes/db.php');
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="../bootstrap-4.0.0-alpha.6/dist/css/bootstrap.min.css">
    <title>Document</title>
    <!--<script src="https://cloud.tinymce.com/stable/tinymce.min.js?apiKey=upwobfx7pi1xyioccwdrsxp8478fjiehzhtaupiyc7eb47xw"></script>-->
  <script>tinymce.init({ selector:'textarea' });</script>
</head>
<body>
    <div class='container-fluid'>

    <form action="insert_product.php" method='POST' enctype="multipart/form-data">
   
    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
            <div class="input-group-addon">Product Title</div>
            <input type="text" class="form-control"  placeholder="title" name="product_title">
  </div>
    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
            <div class="input-group-addon">Product Brand</div>
            <select class="form-control" name="product_brand">
            <option>Select Brand</option>
             <?php 
            
                $query = mysqli_query($conn,"select * from brand");

                while($row = mysqli_fetch_array($query)){
                ?>
               
            
                <option value="<?php echo $row['brand_id'] ?>"><?php echo $row['brand_title']?></option>

                <?php
                }
                
                ?>
           </select>
  </div>
    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
            <div class="input-group-addon">Product Category</div>
           <select name="product_cat"  class='form-control' >
               <option>Select Category</option>
             <?php 
            
                $query = mysqli_query($conn,"select * from categories");

                while($row = mysqli_fetch_array($query)){
                ?>
               
            
                <option value="<?php echo $row['cat_id'] ?>"><?php echo $row['cat_title']?></option>

                <?php
                }
                
                ?>
           </select>
  </div>
    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
            <div class="input-group-addon">Product Price</div>
            <input type="text" class="form-control"  placeholder="Price" name="product_price">
  </div>
    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
            <div class="input-group-addon">Product Description</div>
            <textarea class="form-control" placeholder='Description...' name="product_desc"></textarea>
  </div>
    <div class="input-group mb-2 mr-sm-2 mb-sm-0">
            <div class="input-group-addon">Product Keywords</div>
            <input type="text" class="form-control"  placeholder="Keywords" name="product_keywords">
  </div>
  <div class="input-group mb-2 mr-sm-2 mb-sm-0">
            <div class="input-group-addon">Status</div>
           <select name="status"  class='form-control' >
               <option value='1'>ON</option>
               <option value='0'>OFF</option>
           
           </select>
  </div>
  <label class="custom-file">
  <input type="file" id="file" class="custom-file-input" name="file1">
  <span class="custom-file-control">img1 </span>
    </label>
  <label class="custom-file">
  <input type="file" id="file" class="custom-file-input" name="file2">
  <span class="custom-file-control">img2 </span>
    </label>
  <label class="custom-file">
  <input type="file" id="file" class="custom-file-input" name="file3">
  <span class="custom-file-control">img3 </span>
    </label>
  <input type="submit"  class="form-control" name="insertProduct" value="Submit">
    
    </form>
    </div>
</body>
</html>

<?php 

if(isset($_POST['insertProduct'])){
    $product_title         = $_POST['product_title'];
    $product_brand         = $_POST['product_brand'];
    $product_cat           = $_POST['product_cat'];
    $product_price         = $_POST['product_price'];
    $product_desc          = $_POST['product_desc'];
    $product_keywords      = $_POST['product_keywords'];
    $status                 = $_POST['status'];
    $file1name                 = $_FILES['file1']['name'];
    $file2name                 = $_FILES['file2']['name'];
    $file3name                 = $_FILES['file3']['name'];
    // temporary image name
    $file1tem                 = $_FILES['file1']['tmp_name'];
    $file2tem                 = $_FILES['file2']['tmp_name'];
    $file3tem                 = $_FILES['file3']['tmp_name'];

    if($product_title== ''OR $product_brand==''OR $product_cat==''OR $product_price==''OR $product_keywords == '' OR $product_desc==''OR $product_keywords==''OR $status == ''OR $file1name==''OR $file2name==''OR $file3name=='' ){
      echo '<script>alert("Please fill all the fields")</script>';
      exit();
    }
    else{
     
        move_uploaded_file($file1tem,'product_images/'.$file1name);
        move_uploaded_file($file2tem,'product_images/'.$file2name);
        move_uploaded_file($file3tem,'product_images/'.$file3name);


        $insertProduct = mysqli_query($conn,"INSERT INTO 
        `products`(`cat_id`, `brand_id`, 
        `date`, `product_title`, `product_img1`,
         `product_img2`, `product_img3`, `product_price`,
          `product_desc`,`product_key`, `status`) 
          VALUES ('$product_cat','$product_brand',NOW(),'$product_title ','$file1name'
          ,'$file2name','$file3name','$product_price','$product_desc','$product_keywords','$status')");
          if($insertProduct){
            echo "<script>alert('Product Successfully added');</script>";
          }
          else{
            echo "<script>alert('Product did not add');</script>";
          }
    }

  
    
}

?>
 