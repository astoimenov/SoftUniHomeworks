function cylinderVol (radius, height) {
	var volume = Math.PI * radius * radius * height;
	jsConsole.writeLine('Volume = ' + volume.toFixed(3));
}
