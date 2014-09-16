<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>02. TextColorer</title>
	<style type="text/css">
		.red {
			color: red;
		}
		.blue {
			color: blue;
		}
	</style>
</head>
<body>
	<form method="post">
		<textarea name="text" cols="30" rows="5"></textarea><br>
		<input type="submit" value="Color text" name="submit">
	</form>
	<?php if( isset( $_POST['submit'] ) && isset( $_POST['text'] ) ) : ?>
	<?php
	$chars = str_split( $_POST['text'] );
	foreach ($chars as $char) : ?>
	<span class="<?php echo ( ord( $char ) % 2 === 0 ) ? 'red' : 'blue' ; ?>">
		<?php echo $char . ' '; ?>
	</span>
	<?php endforeach; ?>
	<?php endif; ?>
</body>
</html>
