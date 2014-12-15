<?php

	class SingleRoom extends Room
	{
		function __construct( $roomNumber, $price )
		{
			$extras = array("TV", "Air-conditioner");

			parent::__construct(
				RoomType::STANDART, true, false, 1,
				$roomNumber, $extras, $price );
		}

		function __toString()
		{
			$output = self::class . "<br>";
			$output .= parent::__toString();
			return $output;
		}
	}