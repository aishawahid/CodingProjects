<?php

require_once "config.php";

session_start();

$uid = $_SESSION["id"];
$name = "";
$img = "";

$sql_name = "SELECT * FROM owner_info WHERE owner_id = '$uid'";
$result = mysqli_query($conn,$sql_name);
$row = mysqli_fetch_assoc($result);
$name = $row["owner_name"];
$img = $row["owner_img"];

if($img === NULL){
  $img = "images/profile.jpg";
}

?>

<!DOCTYPE html>
<html lang=en>
 <head>
    <title>Patch - Profile</title>
    <link rel="icon" type="image/x-ico" href="images/favicon.ico"/>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="styles/main.css">
    <link rel="stylesheet" href="styles/profile-styles.css">
 </head>

 <body>
    <header style="position:relative; padding: 0.5rem">


        <nav >
            <img src="images/logo_w.png" style="width:3.5rem;height:3.5rem; position:relative; left: 1rem;" alt="PATCH">

            <div class="navbar">

                <div class="dropdown">
                    <button class="dropbtn">
                        MENU
                        <i class="fa fa-caret-down"></i>
                    </button>
                    <div class="dropdown-content">
                        <a href="welcome.php">HOME</a>
                        <a href="pet.php">PETS</a>
                    </div>
                </div>
           </div>
        </nav>


    </header>

    <main>

        <div class="container "  style="height: 83vh; ">
            <div class="image" >
                <img src= "images/profile.jpg" style="display:block ; max-width:100%;max-height:100%;  position: relative;  " alt="owner profile image"/>
            </div>
            <div >
                <h1>HELLO</h1>
                <h3><?php echo $name; ?></h3>
            </div>
            <!-- <div>
                <h3 style="background-image: linear-gradient(to right, #75d062, #4ac9b1);color: white;position:sticky; bottom: -6em; text-align: center;"> Account settings </h3>
            </div> -->
        </div>


    </main>

    <footer>
        <div style="text-align: left;padding: 2rem ;position: relative; ">
        </div>
    </footer>
 </body>

</html>
