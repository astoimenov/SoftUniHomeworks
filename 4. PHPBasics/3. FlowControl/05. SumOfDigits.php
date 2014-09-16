<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>05. SumOfDigits</title>
</head>
<body>
	<form method="post">
		<label for="input">Input string: </label>
		<input type="text" name="input">
		<input type="submit" value="Submit" name="submit">
	</form>
	<?php if( isset( $_POST['submit'] ) && isset( $_POST['input'] ) ) : ?>
	<table border="1">
		<tbody>
		<?php
		$tokens = explode( ', ', $_POST['input'] );
		foreach ( $tokens as $token ) : ?>
		<?php
		$sum = 0;
		if ( is_numeric( $token ) ) {
			$digits = str_split( $token );
			foreach ( $digits as $digit ) {
				$sum += $digit;
			}
		} else {
			$sum = 'I cannot sum that';
		}
		?>
			<tr>
				<td><?php echo $token; ?></td>
				<td><?php echo $sum; ?></td>
			</tr>
		<?php endforeach; ?>

		</tbody>
	</table>
	<?php endif; ?>
</body>
</html>
