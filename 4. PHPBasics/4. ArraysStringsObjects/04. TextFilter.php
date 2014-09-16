<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>04. TextFilter</title>
</head>
<body>
	<form method="post">
		<textarea name="text" cols="30" rows="5"></textarea><br>
		<label for="banlist">Banlist: </label>
		<input type="text" name="banlist"><br>
		<input type="submit" value="GO!" name="submit">
	</form>
	<?php if( isset( $_POST['submit'] ) ) : ?>
	<?php
	$text = $_POST['text'];
	$banlist = explode( ', ', $_POST['banlist'] );
	foreach ($banlist as $word) {
		$text = str_replace( $word, str_repeat( '*', strlen( $word ) ), $text );
	}
	echo $text;
	?>
	<?php endif; ?>
</body>
</html>
