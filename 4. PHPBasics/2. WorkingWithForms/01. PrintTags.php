<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>01. PrintTags</title>
</head>
<body>
	<form action="" method="post">
		<input type="text" name="tags">
		<input type="submit" value="Submit" name="submit">
	</form>
	<?php
	if( isset( $_POST['submit'] ) && isset( $_POST['tags'] ) ) {
		$tagsInput = $_POST['tags'];
		$tags = explode( ', ', $tagsInput );

		foreach ($tags as $key => $tag) {
			echo $key . ' : ' . $tag . '<br>';
		}
	}
	?>
</body>
</html>
