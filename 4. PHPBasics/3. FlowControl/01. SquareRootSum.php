<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>01. SquareRootSum</title>
</head>
<body>
	<table border="1">
		<thead>
			<tr>
				<th>Number</th>
				<th>Square</th>
			</tr>
		</thead>
		<tbody>
		<?php
		$sum = 0;
		$sq = 0;
		for ( $i=0; $i <= 100; $i+=2 ) : ?>
			<tr>
				<td><?php echo $i; ?></td>
				<td><?php
					$sq = sqrt( $i );
					$sum += $sq;
					echo round( $sq, 2 ); ?></td>
			</tr>
		<?php endfor; ?>
		</tbody>
		<tfoot>
			<tr>
				<td>Total:</td>
				<td><?php echo round( $sum, 2 ); ?></td>
			</tr>
		</tfoot>
	</table>
</body>
</html>
