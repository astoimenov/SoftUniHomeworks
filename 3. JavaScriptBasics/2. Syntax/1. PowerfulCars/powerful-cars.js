function convertToHP() {
	var kW = jsConsole.readInteger('#tb-number');
	var hp = kW * 1.34102209;
	jsConsole.writeLine(kW + 'kW = ' + hp.toFixed(2) + 'hp');
}
