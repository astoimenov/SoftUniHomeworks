<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>04. HTMLTagsCounter</title>
</head>
<body>
	<form action="" method="post">
		<label for="tag">Enter HTML Tag: </label><br>
		<input type="text" name="tag">
		<input type="submit" value="Submit" name="submit">
	</form>
	<?php
	if ( isset( $_POST['submit'] ) ) {
		session_start();
		$tag = $_POST['tag'];
		$score = 0;
		$validTags = array('a', 'abbr', 'acronym', 'address', 'applet', 'area', 'b', 'base', 'basefont',
                    'bdo', 'bgsound', 'big', 'blockquote', 'blink', 'body', 'br', 'button', 'caption', 'center', 'cite', 'code',
                    'col', 'colgroup', 'dd', 'dfn', 'del', 'dir', 'dl', 'div', 'dt', 'embed', 'em', 'fieldset', 'font', 'form',
                    'frame', 'frameset', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'head', 'hr', 'html', 'iframe', 'img', 'input',
                    'ins', 'isindex', 'i', 'kbd', 'label', 'legend', 'li', 'link', 'marquee', 'menu', 'meta', 'noframe',
                    'noscript', 'optgroup', 'option', 'ol', 'p', 'pre', 'q', 's', 'samp', 'script', 'select', 'small', 'span', 'strike',
                    'strong', 'style', 'sub', 'sup', 'table', 'td', 'th', 'tr', 'tbody', 'textarea', 'tfoot', 'thead', 'title',
                    'tt', 'u', 'ul', 'var');


		if ( in_array( $tag, $validTags ) ) {
			if ( isset( $_SESSION['score'] ) ){
				$_SESSION['score'] += 1;
			} else {
				$_SESSION['score'] = 0;
				$_SESSION['score'] += 1;
			}
			echo '<h3>Valid HTML tag!</h3>';
		} else {
			echo '<h3>Invalid HTML tag!</h3>';
		}
		echo '<br><h4>Score: ' . $_SESSION['score'] . '</h4>';
	}
	?>
</body>
</html>
