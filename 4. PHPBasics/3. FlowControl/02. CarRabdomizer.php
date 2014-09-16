<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>02. CarRandomizer</title>
</head>
<body>
	<form method="post">
		<label for="cars">Enter cars: </label>
		<input type="text" name="cars">
		<input type="submit" value="Show result" name="submit">
	</form>
	<?php if( isset( $_POST['submit'] ) ) : ?>
	<table border="1">
		<thead>
			<tr>
				<th>Car</th>
				<th>Color</th>
				<th>Count</th>
			</tr>
		</thead>
		<tbody>
			<?php
			if ( isset( $_POST['cars'] ) ) {
				$cars = explode( ', ', $_POST['cars'] );
			}
			$colors = ['black', 'white', 'blue', 'yellow', 'red'];
			foreach ($cars as $car) : ?>
			<tr>
				<td><?php echo $car; ?></td>
				<td><?php echo $colors[array_rand( $colors )]; ?></td>
				<td><?php echo rand( 1, 5 ); ?></td>
			</tr>
			<?php endforeach; ?>
		</tbody>
	</table>
	<?php endif; ?>
</body>
</html>
