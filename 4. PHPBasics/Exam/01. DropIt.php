<?php

$text = $_GET['text'];
$minFontSize = intval($_GET['minFontSize']);
$maxFontSize = intval($_GET['maxFontSize']);
$step = intval($_GET['step']);

$letter = '';
$isAsciiEven = true;
$fontSize = $minFontSize;
$result = '';

for ( $i = 0; $i < strlen( $text ); $i += 1 ) {
	$letter = $text[$i];

	$result = '<span style=\'font-size:' . htmlspecialchars( $fontSize ) . ';';
	$isAsciiEven = asciiOddOrEven( $text[$i] );

	if ( $isAsciiEven ) {
		$result .= 'text-decoration:line-through;';
	}

	$result .= '\'>' . htmlspecialchars( $letter )  . '</span>';

	echo $result;

	if ( ctype_alpha( $letter ) ) {
		if ( $fontSize >= $maxFontSize ) {
			$step = -$step;
		} elseif ( $fontSize <= $minFontSize && $i != 0 ) {
			$step = -$step;
		}
		$fontSize += $step;
	}
}


function asciiOddOrEven( $ch ) {
	if ( ord( $ch ) % 2 == 0 ) {
		return true;
	} else {
		return false;
	}
}