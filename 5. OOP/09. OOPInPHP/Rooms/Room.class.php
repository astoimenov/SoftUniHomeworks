<?php

	abstract class Room implements iReservable
	{
		private $roomType;
		private $hasRestroom;
		private $hasBalcony;
		private $bedCount;
		private $roomNumber;
		private $extras;
		private $price;
		private $reservations;

		function __construct( $roomType, $hasRestroom, $hasBalcony, $bedCount, $roomNumber, $extras, $price )
		{
			$this->setRoomType( $roomType );
			$this->setHasRestroom( $hasRestroom );
			$this->setHasBalcony( $hasBalcony );
			$this->setBedCount( $bedCount );
			$this->setRoomNumber( $roomNumber );
			$this->setExtras( $extras );
			$this->setPrice( $price );
		}

		public function getRoomType()
		{
			return $this->roomType;
		}

		public function setRoomType( $roomType )
		{
			$type  = new ReflectionClass( "RoomType" );
			$types = $type->getConstants();
			if ( !in_array( $roomType, $types ) ) {
				throw new InvalidArgumentException( "Invalid room type!" );
			}

			$this->roomType = $roomType;
		}

		public function getHasRestroom()
		{
			return $this->hasRestroom;
		}

		public function setHasRestroom( $hasRestroom )
		{
			if ( !is_bool( $hasRestroom ) ) {
				throw new InvalidArgumentException( "HasRoom should be boolean type!" );
			}

			$this->hasRestroom = $hasRestroom;
		}

		public function getHasBalcony()
		{
			return $this->hasBalcony;
		}

		public function setHasBalcony( $hasBalcony )
		{
			if ( !is_bool( $hasBalcony ) ) {
				throw new InvalidArgumentException( "HasBalcony should be boolean type!" );
			}

			$this->hasBalcony = $hasBalcony;
		}

		public function getBedCount()
		{
			return $this->bedCount;
		}

		public function setBedCount( $bedCount )
		{
			if ( !is_int( $bedCount ) ) {
				throw new InvalidArgumentException( "Bed count should be integer number!" );
			} elseif ( $bedCount < 0 ) {
				throw new InvalidArgumentException( "Bed count should be positive number!" );
			}

			$this->bedCount = $bedCount;
		}

		public function getRoomNumber()
		{
			return $this->roomNumber;
		}

		public function setRoomNumber( $roomNumber )
		{
			if ( !is_int( $roomNumber ) ) {
				throw new InvalidArgumentException( "Room number should be integer number!" );
			} elseif ( $roomNumber < 0 ) {
				throw new InvalidArgumentException( "Room number should be positive number!" );
			}

			$this->roomNumber = $roomNumber;
		}

		public function getExtras()
		{
			return $this->extras;
		}

		public function setExtras( $extras )
		{
			if ( !is_array( $extras ) ) {
				throw new InvalidArgumentException( "The extras should be presented as array!" );
			}

			$this->extras = $extras;
		}

		public function getPrice()
		{
			return $this->price;
		}

		public function setPrice( $price )
		{
			if ( !is_float( $price ) ) {
				throw new InvalidArgumentException( "Price should be float number!" );
			} elseif ( $price < 0 ) {
				throw new InvalidArgumentException( "Price should be positive number!" );
			}

			$this->price = $price;
		}

		public function getReservations()
		{
			return $this->reservations;
		}

		public function setReservations( $reservations )
		{
			$this->reservations = $reservations;
		}

		function addReservation( $reservation )
		{
			if ( count( $this->reservations ) == 0 ) {
				$this->reservations[] = $reservation;
			} else {
				$isReserved = false;
				foreach ( $this->reservations as $r1 ) {
					if ( $this->isReservationsOverLap( $r1, $reservation ) ) {
						$isReserved = true;
					}
				}

				if ( !$isReserved ) {
					array_push( $this->reservations, $reservation );
				} else {
					throw new EReservationException( $reservation );
				}
			}
		}

		function removeReservation( $reservation )
		{
			if ( ( $key = array_search( $reservation, $this->reservations ) ) !== false ) {
				unset( $this->reservations[$key] );
			}
		}

		private function isReservationsOverLap( $r1, $r2 )
		{
			return $r2->getStartDate() < $r1->getEndDate() && $r1->getStartDate() < $r2->getEndDate();
		}

		function __toString()
		{
			$output = "Room type: " . $this->getRoomType() . "<br>";
			if( $this->hasRestroom ) {
				$output .= "Restroom";
				if( $this->hasBalcony ) {
					$output .= ", Balcony<br>";
				}
			} elseif ( $this->hasBalcony ) {
				$output .= "Balcony<br>";
			}
			$output .= "Beds: " . $this->bedCount . ", Room № " . $this->roomNumber . "<br>";
			$output .= "Extras: " . implode( ", ", $this->extras ) . "<br>";
			$output .= "Price: " . $this->price . "lv.<br>";
			if( !empty( $this->reservations ) ) {
				$output .= "Reservations:<br>";
				$output .= implode( "<br>", $this->reservations );
			}
			return $output;
		}
	}

	interface iReservable
	{
		public function addReservation( $reservation );

		public function removeReservation( $reservation );
	}