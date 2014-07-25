function findMostFreqWord(str) {
    var wordCounts = {};
    var words = str.split(/\b/);

    for (var i = 0; i < words.length; i++) {
        if (words[i].match(/\w/)) {
            wordCounts['_' + words[i].toLowerCase()] = (wordCounts['_' + words[i].toLowerCase()] || 0) + 1;
        }
    }
    var counts = Object.keys(wordCounts).map(function(key) {
        return wordCounts[key];
    });

    var keys = Object.keys(wordCounts);
    keys.sort();

    var maxCount = Math.max.apply(Math, counts);

    for (var key in keys) {
        if (keys[key].length > 0) {
            if (wordCounts[keys[key]] === maxCount) {
                jsConsole.writeLine(keys[key].replace('_', '') + ' -> ' + maxCount + ' times');
            }
        }
    }
    jsConsole.writeLine();
}
