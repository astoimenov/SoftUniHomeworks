<?php

class Guest {
	private $firstName;
	private $lastName;
	private $id;

	function __construct( $firstName, $lastName, $id )
	{
		$this->setFirstName( $firstName );
		$this->setLastName( $lastName );
		$this->setId( $id );
	}

	public function getFirstName()
	{
		return $this->firstName;
	}

	public function setFirstName( $firstName )
	{
		$this->firstName = $firstName;
	}

	public function getLastName()
	{
		return $this->lastName;
	}

	public function setLastName( $lastName )
	{
		$this->lastName = $lastName;
	}

	public function getId()
	{
		return $this->id;
	}

	public function setId( $id )
	{
		$this->id = $id;
	}

	function __toString()
	{
		$output = $this->firstName . " " . $this->lastName . ", ID " . $this->id;
		return $output;
	}


} 