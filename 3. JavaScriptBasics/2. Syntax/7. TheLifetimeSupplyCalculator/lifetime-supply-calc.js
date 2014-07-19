function calcSupply (age, maxAge, amount) {
	var span = (maxAge - age) * 365;
	var supply = span * amount;
	jsConsole.writeLine(supply + 'kg of fav food would be enough until I am ' + maxAge + ' years old.');
}
