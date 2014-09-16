<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>05. SentenceExtractor</title>
</head>
<body>
	<form action="" method="post">
		<textarea name="text" cols="30" rows="5"></textarea><br>
		<label for="word">Word: </label>
		<input type="text" name="word"><br>
		<input type="submit" value="Submit" name="submit">
	</form>
	<?php
		if ( isset( $_POST['submit'] ) ) {
			$text = $_POST['text'];
			$word = $_POST['word'];
			$sentences = preg_split( '/(?<=[.?!])\s+(?=[a-z])/i', $text );

			foreach ($sentences as $sentence) {
				if ( !strpos( $sentence, ' ' . $word ) === false
					&& ( endsWith( $sentence, '.' )
					|| endsWith( $sentence, '!' )
					|| endsWith( $sentence, '?' ) ) ) {
					echo $sentence . '<br>';
				}
			}
		}

		function endsWith( $str, $sub ) {
		    return ( substr( $str, strlen( $str ) - strlen( $sub ) ) == $sub );
		}

	?>
</body>
</html>
