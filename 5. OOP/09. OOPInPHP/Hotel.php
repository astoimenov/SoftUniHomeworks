<?php

	include "autoloader.php";
	include "BookingManager.class.php";

	$room = new SingleRoom(1408, 99.0);
	$guest = new Guest("Svetlin", "Nakov", 8003224277);
	$startDate = "24.10.2014";
	$endDate = "26.10.2014";
	$reservation = new Reservation($startDate, $endDate, $guest);
	BookingManager::bookRoom($room, $reservation);

	echo "<br>";

	$rooms = array(
		new SingleRoom( 123, 569.3 ),
		new SingleRoom( 129, 236.9 ),
		new SingleRoom( 125, 246.7 ),
		new Apartment( 258, 246.7 ),
		new Apartment( 253, 305.1 ),
		new Apartment( 251, 215.29 ),
		new Bedroom( 397, 205.37 ),
		new Bedroom( 391, 101.74 ),
		new Bedroom( 396, 459.2 )
	);

	$sortedByPrice = array_filter( $rooms, function ( $r ) {
		if( ( get_class($r) == 'Apartment' || get_class($r) == 'Bedroom' ) && $r->getPrice() <= 250 ) {
			return $r;
		}
	} );

	echo "<strong>Bedrooms and Apartments with price <= 250:</strong><br><br>";
	foreach ( $sortedByPrice as $r ) {
		echo $r . "<br>";
	}

	$withBalcony = array_filter( $rooms, function ( $r ) {
		if ( $r->getHasBalcony() ) {
			return $r;
		}
	} );

	echo "<strong>Rooms with balcony:</strong><br><br>";
	foreach ( $withBalcony as $r ) {
		echo $r . "<br>";
	}

	$withBathtub = array();
	foreach ( $rooms as $r ) {
		if ( in_array( "bathtub", $r->getExtras() ) || in_array( "Bathtub", $r->getExtras() ) ) {
			array_push( $withBathtub, $r->getRoomNumber() );
		}
	}

	echo "<strong>Room numbers of rooms with bathtub:</strong><br><br>";
	echo implode( ", ", $withBathtub );



