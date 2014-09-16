<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>03. AnnualExpenses</title>
</head>
<body>
	<form method="post">
		<label for="years">Enter number of years: </label>
		<input type="text" name="years">
		<input type="submit" value="Show costs" name="submit">
	</form>
	<?php if( isset( $_POST['submit'] ) ) : ?>
	<table border="1">
		<thead>
			<tr>
				<th>Year</th>
				<th>January</th>
				<th>February</th>
				<th>March</th>
				<th>April</th>
				<th>May</th>
				<th>June</th>
				<th>July</th>
				<th>August</th>
				<th>September</th>
				<th>October</th>
				<th>November</th>
				<th>December</th>
				<th>Total:</th>
			</tr>
		</thead>
		<tbody>
			<?php
			if ( isset( $_POST['years'] ) ) {
				$years = $_POST['years'];
			}
			$rand = 0;
			$sum = 0;
			for ( $i = 2014; $i > 2014 - $years; $i -= 1 ) : ?>
			<tr>
				<td><?php echo $i; ?></td>
				<?php for ( $col = 0; $col < 12; $col ++ ) : ?>
				<td>
					<?php
					$rand = rand( 0, 999 );
					$sum += $rand;
					echo $rand;
					?>
				</td>
				<?php endfor; ?>
				<td><?php echo $sum; $sum = 0; ?></td>
			</tr>
			<?php endfor; ?>
		</tbody>
	</table>
	<?php endif; ?>
</body>
</html>
