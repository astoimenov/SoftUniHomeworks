function convertToHP() {
	var number = jsConsole.readFloat('#tb-number');
	var floor = Math.floor(number);
	var round = Math.round(number);
	jsConsole.writeLine('Floor = ' + floor);
	jsConsole.writeLine('Round = ' + round);
	jsConsole.writeLine();
}
