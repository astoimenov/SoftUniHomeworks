<?php

require_once("Reservation.class.php");
class BookingManager {
	static function bookRoom( $room, $reservation ) {
		$room->addReservation( $reservation );
		echo "Room <strong>" . $room->getRoomNumber() . "</strong> successfully booked for <strong>" . $reservation->getGuest()->getFirstName() . " " . $reservation->getGuest()->getLastName() . "</strong> from <time>" . $reservation->getStartDate() . "</time> to <time>" . $reservation->getEndDate() . "</time>!<br>";
	}
} 