<?php

	class Apartment extends Room
	{

		function __construct( $roomNumber, $price )
		{
			$extras = array("TV", "Air-conditioner",
				"Refrigerator", "Mini-bar", "Bathtub", "Kitchen box", "Free Wi-Fi");

			parent::__construct( RoomType::DIAMOND, true, true, 4, $roomNumber, $extras, $price );
		}

		function __toString()
		{
			$output = self::class . "<br>";
			$output .= parent::__toString();
			return $output;
		}
	}