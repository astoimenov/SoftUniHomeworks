<?php
	function autoload( $className )
	{
		set_include_path( 'rooms/' );
		spl_autoload( $className ); //replaces include/require
	}

	spl_autoload_extensions( '.class.php' );
	spl_autoload_register( 'autoload' );