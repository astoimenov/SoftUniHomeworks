<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>07. GetFormData</title>
</head>
<body>
	<form method="post">
		<input type="text" name="name" placeholder="Name..."><br>
		<input type="number" name="age" placeholder="Age..."><br>
		<input type="radio" name="gender" value="male"> Male<br>
		<input type="radio" name="gender" value="female"> Female<br>
		<input type="submit" value="Изпращане" name="submit">
	</form>
	<?php
	if (isset($_POST['submit'])) {
		if (isset($_POST['name']) && isset($_POST['age']) && isset($_POST['gender'])) {
			$name = $_POST['name'];
			$age = $_POST['age'];
			$gender = $_POST['gender'];
			echo 'My name is ' . $name . '. I am ' . $age . ' years old. I am ' . $gender . '.';
		}
	}
	?>
</body>
</html>
