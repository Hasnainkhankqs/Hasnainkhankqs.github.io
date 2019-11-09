<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Untitled Document</title>
<meta name="viewport" content="width=device-width, initial-scale=1"> 
    
    <link rel="stylesheet" href= "../css/bootstrap.min.css"> 
      
    <script src= "https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"> 
    </script> 
      
    <script src= "https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"> 
    </script> 
      
    <script src= "../js/bootstrap.min.js"> 
    </script> 
</head>

<body>
<form  method="post" action="fee_details.php">
       <div class="container">  
      
        <h1 style="text-align:center;color:green;"> 
           Student's Detail 
        </h1>  
      
        <!-- Bootstrap table class -->
        <table class="table">  
            <thead>  
                <tr>  
                    <th scope="col">Roll#. No.</td>  
                    <th scope="col">Name</td>  
                    <th scope="col">Father Name</td>  
                    <th scope="col">Age</td>  
                    <th scope="col">Class</td>  
                </tr>  
            </thead>  
              
            <tbody>  
                <tr>  
                    <th scope="row">1</td>  
                    <td>Asad</td>  
                    <td>Ali</td>  
                    <td>20</td>
                    <td>6th</td>  
                </tr>
                <input type="submit" value="Ceck Fee Status" name="std" style="background-color: darkgreen;color: aliceblue">  
            </tbody>  
        </table>  
    </div>
    </form>
    
   
<?php

if(isset($_POST['std']))
{
	
}

?>
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
</body>
</html>