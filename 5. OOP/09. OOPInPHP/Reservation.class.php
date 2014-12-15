<?php

	class Reservation
	{
		private $startDate;
		private $endDate;
		private $guest;

		function __construct( $startDate, $endDate, $guest )
		{
			$this->setStartDate( $startDate );
			$this->setEndDate( $endDate );
			$this->setGuest( $guest );
		}

		public function getEndDate()
		{
			return $this->endDate;
		}

		public function setEndDate( $endDate )
		{
			$endDateArray = explode( ".", $endDate );
			if ( !checkdate( $endDateArray[1], $endDateArray[0], $endDateArray[2] ) ) {
				throw new InvalidArgumentException( "Invalid date!" );
			} elseif ( strtotime( $this->startDate ) > strtotime( $endDate ) ) {
				throw new InvalidArgumentException( "The end date should be after start date!" );
			}

			$this->endDate = $endDate;
		}

		public function getStartDate()
		{
			return $this->startDate;
		}

		public function setStartDate( $startDate )
		{
			$startDateArray = explode( ".", $startDate );
			if ( !checkdate( $startDateArray[1], $startDateArray[0], $startDateArray[2] ) ) {
				throw new InvalidArgumentException( "Invalid date!" );
			}

			$this->startDate = $startDate;
		}

		public function getGuest()
		{
			return $this->guest;
		}

		public function setGuest( $guest )
		{
			if ( !( $guest instanceof Guest ) ) {
				throw new InvalidArgumentException( "Invalid guest!" );
			}

			$this->guest = $guest;
		}

		function __toString()
		{
			$output = $this->guest . " : " . $this->getStartDate() . " - " . $this->getEndDate();
			return $output;
		}
	}