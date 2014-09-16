<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>04. NonRepeatingDigits</title>
</head>
<body>
	<form method="post">
		<label for="number">Number: </label>
		<input type="text" name="number">
		<input type="submit" value="Submit">
	</form>
	<?php
	if (isset($_POST['number'])) {
		$number = $_POST['number'];
		$results = [];

		if ($number < 102) {
			echo 'no';
		} else {
			if ($number > 987) {
				$number = 987;
			}
			for ($i=102; $i <= $number; $i++) {
				$firstDigit = floor($i / 100);
				$secondDigit = floor(($i / 10) % 10);
				$thirdDigit = floor($i % 10);

				if ($firstDigit != $secondDigit && $secondDigit != $thirdDigit && $firstDigit != $thirdDigit) {
					array_push($results, $i);
				}
			}

			echo implode(', ', $results);
		}
	}
	?>
</body>
</html>
