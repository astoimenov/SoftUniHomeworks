<?php
date_default_timezone_set('Europe/Sofia');
$parsedText = preg_split ( '/$\R?^/m', $_GET['text'] );

$articles = [];
$article = [];
$matches = [];
$result = '';

for ($i=0; $i < count($parsedText); $i++) {
	$topicPos = strpos( $parsedText[$i], '%' );
	$topic = trim( substr( $parsedText[$i], 0, $topicPos ) );
	$authorPos = strpos( $parsedText[$i], ';' );
	$author = trim( substr( $parsedText[$i], $topicPos + 1, $authorPos - $topicPos - 1 ) );
	$dates = preg_match( '/(\d{1,2}-\d{1,2}-\d{4})/', $parsedText[$i], $matches );
	if( !empty( $matches ) ) {
		$date = $matches[0];
	}
	$month = date( 'F', strtotime( $date ) );
	$summaryPos = strposX( $parsedText[$i], '-', 3 );
	$summary = trim( substr( $parsedText[$i], $summaryPos + 1, strlen( $parsedText[$i] ) - $summaryPos + 1 ) );
	$summary = substr( $summary, 0, 100);

	if ( $topic == '' || $author == '' || $month == '' || $summary == '' ) {
		break;
	}

	$result .= "<div>\n<b>Topic:</b> <span>" . htmlspecialchars( $topic ) . "</span>\n";
	$result .= "<b>Author:</b> <span>" . htmlspecialchars( $author ) . "</span>\n";
	$result .= "<b>When:</b> <span>" . htmlspecialchars( $month ) . "</span>\n";
	$result .= "<b>Summary:</b> <span>" . htmlspecialchars( $summary ) . "...</span>\n";
	$result .= "</div>\n";
}

echo $result;


function strposX( $haystack, $needle, $number ){
    if( $number == '1' ){
        return strpos( $haystack, $needle );
    }elseif($number > '1'){
        return strpos( $haystack, $needle, strposX( $haystack, $needle, $number - 1 ) + strlen( $needle ) );
    }
}