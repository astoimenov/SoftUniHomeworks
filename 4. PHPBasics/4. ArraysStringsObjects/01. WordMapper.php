<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>01. WordMapper</title>
</head>
<body>
	<form method="post">
		<textarea name="text" cols="30" rows="5"></textarea><br>
		<input type="submit" value="Count words" name="submit">
	</form>
	<table>
	<?php if (isset($_POST['submit']) && isset($_POST['text'])):?>
	<?php $text = strtolower($_POST['text']);
	$words = array_count_values(str_word_count($text, 1));?>
	<?php foreach ($words as $key => $value):?>
	<tr>
		<td><?php echo $key;?></td>
		<td><?php echo $value;?></td>
	</tr>
	<?php endforeach;?>
	<?php endif;?>
</table>
</body>
</html>
