<?php

	class Bedroom extends Room
	{

		function __construct( $roomNumber, $price )
		{
			$extras = array("TV", "Air-conditioner", "Refrigerator", "Mini-bar", "Bathtub");

			parent::__construct( RoomType::GOLD, true, true, 2, $roomNumber, $extras, $price );
		}

		function __toString()
		{
			$output = self::class . "<br>";
			$output .= parent::__toString();
			return $output;
		}
	}