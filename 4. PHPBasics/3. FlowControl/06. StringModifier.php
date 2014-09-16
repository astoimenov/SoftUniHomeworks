<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>06. StringModifier</title>
</head>
<body>
	<form method="post">
		<input type="text" name="string">
		<input type="radio" name="modifier" value="palindrome" id="palindrome">
		<label for="palindrome">Check palindrome</label>
		<input type="radio" name="modifier" value="reverse" id="reverse">
		<label for="reverse">Reverse string</label>
		<input type="radio" name="modifier" value="split" id="split">
		<label for="split">Split</label>
		<input type="radio" name="modifier" value="hash" id="hash">
		<label for="hash">Hash string</label>
		<input type="radio" name="modifier" value="shuffle" id="shuffle">
		<label for="shuffle">Shuffle string</label>
		<input type="submit" value="Submit" name="submit">
	</form>
<?php if (isset($_POST['submit']) && isset($_POST['string'])) {
	$inputStr = $_POST['string'];
	$modifier = $_POST['modifier'];

	switch ($modifier) {
		case 'palindrome':
			echo $inputStr.' is '
			.($inputStr == strrev($inputStr)?'':'not').' a palindrome!';
			break;
		case 'reverse':
			echo strrev($inputStr);
			break;
		case 'split':
			$result = implode(' ', str_split($inputStr));
			echo $result;
			break;
		case 'hash':
			echo crypt($inputStr);
			break;
		case 'shuffle':
			echo str_shuffle($inputStr);
			break;
		default:
			echo 'Error!';
			break;
	}
}?>
</body>
</html>
