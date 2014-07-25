function createArray() {
    var numbers = [];
    for (var i = 0; i < 20; i += 1) {
        numbers[i] = i * 5;
    }

    document.getElementById('js-console').innerHTML += '<div id="rights">Microsoft Windows [Version 6.3.9600]<br>(c) 2013 Microsoft Corporation. All rights reserved.</div><br>' + '<div class="console-line">C:&gt; ' + numbers + '</div><div class="console-line">C:&gt; _</div>';
}
createArray();
