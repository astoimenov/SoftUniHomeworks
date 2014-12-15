<?php

$songs = preg_split ( '/$\R?^/m', $_GET['text'] );
$artist = $_GET['artist'];
$property = $_GET['property'];
$order = $_GET['order'];

$printedSongs = [];
$pSongs = [];
$items = [];
$result = '';

foreach ($songs as $song) {
	$tokens = explode( ' | ', $song );
	if ( strstr( $tokens[2], $artist ) !== false ) {
		$printedSongs[] = $song;
	}
}

$pSongs = makeAssoc( $printedSongs, $property );

switch ( $order ) {
	case 'ascending':
		asort( $pSongs );
		break;
	case 'descending':
		arsort( $pSongs );
		break;
}

$result = "<table>\n";
$result .= "<tr><th>Name</th><th>Genre</th><th>Artists</th><th>Downloads</th><th>Rating</th></tr>\n";
foreach ( $pSongs as $key => $value ) {
	$items = explode( ' | ', $key );
	$items[2] = sortArtists( $items[2] );
	$result .= '<tr>';
	foreach ($items as $item) {
		$item = str_replace( PHP_EOL, '', $item);
		$item = str_replace("\n", '', $item);
		$item = str_replace("\r", '', $item);
		$item = str_replace("\r\n", '', $item);
		$result .= '<td>' . htmlspecialchars( $item ) . '</td>';
	}
	$result .= "</tr>\n";
	reset( $items );
}
$result .= '</table>';

echo $result;

function makeAssoc( $array, $orderBy ) {
	$num = 0;

	switch ( $orderBy ) {
		case 'name':
			$num = 0;
			break;
		case 'genre':
			$num = 1;
			break;
		case 'downloads':
			$num = 3;
			break;
		case 'rating':
			$num = 4;
			break;
	}


	foreach ($array as $line) {
	    $b = explode(' | ', $line);
	    $assoc[$line] = $b[$num];
	}

	return $assoc;
}

function sortArtists( $artists ) {
	$tokens = explode( ', ', $artists );
	asort( $tokens );
	$sorted = implode( ', ', $tokens );
	return $sorted;
}