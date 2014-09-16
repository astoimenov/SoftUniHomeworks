<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>06. InformationTable</title>
</head>
<body>
	<form method="post">
		<label for="name">Name: </label>
		<input type="text" name="name">
		<label for="phone">Phone number: </label>
		<input type="text" name="phone"><br>
		<label for="age">Age: </label>
		<input type="number" name="age">
		<label for="address">Address: </label>
		<input type="text" name="address">
		<input type="submit" value="Submit" name="submit">
	</form>
	<?php if (isset($_POST['submit'])) : ?>
	<table border="1s" >
		<tr>
			<td>Name</td>
			<td>
				<?php if (isset($_POST['name'])) {
					echo $_POST['name'];
				} ?>
			</td>
		</tr>
		<tr>
			<td>Phone number</td>
			<td>
				<?php if (isset($_POST['phone'])) {
					echo $_POST['phone'];
				} ?>
			</td>
		</tr>
		<tr>
			<td>Age</td>
			<td>
				<?php if (isset($_POST['age'])) {
					echo $_POST['age'];
				} ?>
			</td>
		</tr>
		<tr>
			<td>Address</td>
			<td>
				<?php if (isset($_POST['address'])) {
					echo $_POST['address'];
				} ?>
			</td>
		</tr>
	</table>
<?php endif; ?>
</body>
</html>
