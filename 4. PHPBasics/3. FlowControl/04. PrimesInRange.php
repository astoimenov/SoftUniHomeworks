<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>04. PrimesInRange</title>
	<style type="text/css">
		.prime {
			font-weight: bold;
		}
	</style>
</head>
<body>
	<form method="post">
		<label for="start">Starting index: </label>
		<input type="text" name="start">
		<label for="end"> End: </label>
		<input type="text" name="end">
		<input type="submit" value="Submit" name="submit">
	</form>
	<?php
	function isPrime($num) {
	    if($num == 1)
	        return false;

	    if($num == 2)
	        return true;

	    if($num % 2 == 0)
	        return false;

	    for($i = 3; $i <= ceil(sqrt($num)); $i = $i + 2) {
	        if($num % $i == 0)
	            return false;
	    }

	    return true;
	}

	?>
	<?php if( isset( $_POST['submit'] ) ) : ?>
	<?php for ( $i = $_POST['start']; $i <= $_POST['end'] - 1 ; $i += 1 ) : ?>
	<span <?php echo isPrime( $i ) ? 'class="prime"' : ''; ?>>
		<?php echo $i . ', '; ?>
	</span>
	<?php endfor; ?>
	<span <?php echo isPrime( $_POST['end'] ) ? 'class="prime"' : ''; ?>>
		<?php echo $_POST['end']; ?>
	</span>
	<?php endif; ?>
</body>
</html>
