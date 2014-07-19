function treeHouseCompare (a, b) {
	var tree = b * (b / 3) + Math.PI * (b * 2 / 3) * (b * 2 / 3);
	var house = Math.pow(a, 2) + (a * (a * 2 / 3)) / 2;
	if (tree > house) {
		jsConsole.writeLine("tree/" + tree.toFixed(2));
	} else {
		jsConsole.writeLine("house/" + house.toFixed(2));
	}
}
