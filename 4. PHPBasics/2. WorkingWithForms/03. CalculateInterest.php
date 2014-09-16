<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>03. CalculateInterest</title>
</head>
<body>
	<form action="" method="post">
		<label for="amount">Enter Amount: </label>
		<input type="number" name="amount"><br>
		<input type="radio" name="currency" id="usd" value="usd">
		<label for="usd">USD</label>
		<input type="radio" name="currency" id="eur" value="eur">
		<label for="eur">EUR</label>
		<input type="radio" name="currency" id="bgn" value="bgn">
		<label for="bgn">BGN</label><br>
		<label for="cia">Compound Interest Amount</label>
		<input type="number" name="cia"><br>
		<select name="period" id="period">
			<option value="6m">6 months</option>
			<option value="1y">1 year</option>
			<option value="2y">2 years</option>
			<option value="5y">5 years</option>
		</select>
		<input type="submit" value="Calculate" name="submit">
	</form>
	<?php
	if( isset( $_POST['submit'] ) ){
		$amount = $_POST['amount'];
		$currency = $_POST['currency'];
		$cia = $_POST['cia'];
		$periodVal = $_POST['period'];

		$period = 0;
		$currencySign = '';

		switch ( $periodVal ) {
			case '6m':
				$period = 6;
				break;
			case '1y':
				$period = 12;
				break;
			case '2y':
				$period = 24;
				break;
			case '5y':
				$period = 60;
				break;
			default:
				echo 'Error!';
				break;
		}

		switch ( $currency ) {
			case 'usd':
				$currencySign = ' $';
				break;
			case 'eur':
				$currencySign = ' &#8364;';
				break;
			case 'bgn':
				$currencySign = ' лв.';
				break;
			default:
				echo 'Error!';
				break;
		}

		$interest = round( $amount * pow( 1 + ( ( $cia / 100 ) / 12 ), $period / 12 * 12 ), 2 );

		echo $interest . $currencySign;
	}
	?>
</body>
</html>
