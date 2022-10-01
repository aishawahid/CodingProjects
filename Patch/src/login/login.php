<?php
//Initialising the session
session_start();

//check if user is logged in
if(isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] === true){
  header("Location: ../profile/profile.php");
}

// Include config file
require_once "../../config.php";

function alert($msg) {
  echo $msg;
  header("Location: ../login/login.php");
}


$username = $password = "";
$err = "";
if($_SERVER["REQUEST_METHOD"] === "POST"){

    if(empty($_POST["username"]) || empty($_POST["password"])){
        $err = "Username or Password Not Entered.";
        alert($err);
    } else{
        $username = trim($_POST["username"]);
        $password = trim($_POST["password"]);
    }

    //Validate credentials
    if(empty($err)){
      $sql = "SELECT * FROM owner_info WHERE owner_email = '$username' AND owner_password = '$password'";
      $result = mysqli_query($conn,$sql);
      $numrows = mysqli_num_rows($result);
      if($numrows == 1){
        $row = mysqli_fetch_assoc($result);
    		//if(password_verify($password,$row['owner_password'])){
          session_start();
          // Store data in session variables
          $_SESSION["loggedin"] = true;
          $_SESSION["id"] = $row['owner_id'];
          $_SESSION["username"] = $username;
          // Redirect user to welcome page
          header("Location: ../profile/profile.php");
    		//}
    		//else{
    		//	$err = "Invalid username or password.";
    		//}
    	}
    	else{
    		$err = "Invalid username or password.";
        alert($err);
    	}
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
	<title>Login - Patch</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
</head>
<body>

	<div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100">
				<a class="go-back" href="../home/index.html">
					<span class="fa fa-arrow-left" style="margin-right: .7em;"></span>Go to homepage
				</a>
				<div class="login100-pic js-tilt" data-tilt>
					<img src="images/img-01.png" alt="IMG">
				</div>

				<form class="login100-form validate-form" action = "login.php" method="post">
					<span class="login100-form-title">
						Member Login
					</span>

					<div class="wrap-input100 validate-input" data-validate = "Valid email is required: ex@abc.xyz">
						<input class="input100" type="text" name="username" placeholder="Email">
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-envelope" aria-hidden="true"></i>
						</span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Password is required">
						<input class="input100" type="password" name="password" placeholder="Password">
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-lock" aria-hidden="true"></i>
						</span>
					</div>

					<div class="container-login100-form-btn">
						<button class="login100-form-btn">
							Login
						</button>
					</div>

					<div class="text-center p-t-12">
						<span class="txt1">
							Forgot
						</span>
						<a class="txt2" href="#">
							Username / Password?
						</a>
					</div>

					<div class="text-center p-t-136">
						<a class="txt2" href="#">
							Create your Account
							<i class="fa fa-long-arrow-right m-l-5" aria-hidden="true"></i>
						</a>
					</div>
				</form>
			</div>
		</div>
	</div>

	<script >
		$('.js-tilt').tilt({
			scale: 1.1
		})
	</script>
	<script src="js/main.js"></script>

</body>
</html>
