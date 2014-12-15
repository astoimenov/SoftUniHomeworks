<?php
date_default_timezone_set('Europe/Sofia');
$currentDateInput = $_GET['currentDate'];
$messages = preg_split ( '/$\R?^/m', $_GET['messages'] );

$currentDate = strtotime( $currentDateInput );

$chat = [];
$result = '';

foreach ($messages as $message) {
    $b = explode(' / ', $message);
    $chat[$b[0]] = strtotime( $b[1] );
}

asort( $chat );

foreach ($chat as $key => $value) {
	$result .= '<div>' . htmlspecialchars( $key ) . "</div>\n";
}

$lastMessageDate = end( $chat );
$period = $currentDate - $lastMessageDate;
$lastActive = '';
$time = '';

if ( $period < 60 ) {
	$lastActive = 'a few moments ago';
} elseif ( $period < 3600 ) {
	$time = date( 'i', $period );
	$lastActive = intval( $time ) . ' minute(s) ago';
} elseif ( date( 'd', $currentDate ) == intval( date( 'd', $lastMessageDate ) ) + 1 ) {
	$lastActive = 'yesterday';
} elseif ( $period < 86400 ) {
	$time = date( 'H', $currentDate ) - date( 'H', $lastMessageDate );
	$lastActive = $time . ' hour(s) ago';
} else {
	$lastActive = date( 'd-m-Y', $lastMessageDate );
}

$result .= '<p>Last active: <time>' . htmlspecialchars( $lastActive ) . '</time></p>';

echo $result;