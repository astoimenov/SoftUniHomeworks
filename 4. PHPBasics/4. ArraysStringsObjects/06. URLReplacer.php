<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>06. URLReplacer</title>
</head>
<body>
	<form action="" method="post">
		<textarea name="text" cols="30" rows="5"></textarea><br>
		<input type="submit" value="Submit" name="submit">
	</form>
	<?php
	if( isset( $_POST['submit'] ) ) {
		$text = $_POST['text'];
		$replaced = preg_replace( '/<a href="(.*?)">/', '[URL=\1]', $text );
		$replaced = str_replace( '</a>', '[/URL]', $replaced );
	    echo $replaced;
	} ?>
</body>
</html>



