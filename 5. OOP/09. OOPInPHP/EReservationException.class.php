<?php

	class EReservationException extends Exception
	{

		function __construct( $reservation )
		{
			parent::__construct( "A reservation already exists in that period: $reservation", 101 );
		}
	}