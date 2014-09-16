<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>02. SumTwoNumbers</title>
</head>
<body>
	<form method="post">
		<label for="firstNum">First Number</label>
		<input type="text" name="firstNum" id="firstNum">
		<label for="secondNum">Second Number</label>
		<input type="text" name="secondNum" id="secondNum">
		<input type="submit" value="Calculate">
	</form>
	<?php
		if (isset($_POST['firstNum']) && isset($_POST['secondNum'])) {
			$firstNum = $_POST['firstNum'];
			$secondNum = $_POST['secondNum'];

			$sum = $firstNum + $secondNum;
			$roundedSum = round($sum, 2);

			echo 'Sum = ' . $roundedSum;
		}

	?>
</body>
</html>
