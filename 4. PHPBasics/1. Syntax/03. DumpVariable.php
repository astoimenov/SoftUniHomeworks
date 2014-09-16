<?php
$str = 'hello';
$int = 15;
$double = 1.234;
$arr = [1, 2, 3];
$obj = (object)[2, 34];

$variables = [$str, $int, $double, $arr, $obj];

foreach ($variables as $var) {
	if (is_numeric($var)) {
		var_dump($var);
	} else {
		echo gettype($var);
	}
}

?>
