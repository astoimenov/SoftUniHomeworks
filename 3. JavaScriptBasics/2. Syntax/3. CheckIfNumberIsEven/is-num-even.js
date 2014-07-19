function evenNumber () {
	var number = jsConsole.readInteger('#tb-number');
	if (number % 2) {
		jsConsole.writeLine('false');
	} else {
		jsConsole.writeLine('true');
	}
}
