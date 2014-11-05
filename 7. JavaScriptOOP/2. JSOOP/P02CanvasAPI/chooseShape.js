function chooseShape() {
    var shapeOption = document.getElementById('shape');
    var shape = shapeOption.options[shapeOption.selectedIndex].value;

    var circleForm = document.getElementById('circleForm');
    var rectForm = document.getElementById('rectangleFrom');
    var segForm = document.getElementById('segmentForm');
    var triForm = document.getElementById('triangleForm');

    if (shape === 'circle') {
        circleForm.style.display = 'block';
        rectForm.style.display = 'none';
        segForm.style.display = 'none';
        triForm.style.display = 'none';
    } else if (shape === 'rectangle') {
        circleForm.style.display = 'none';
        rectForm.style.display = 'block';
        segForm.style.display = 'none';
        triForm.style.display = 'none';
    } else if (shape === 'segment') {
        circleForm.style.display = 'none';
        rectForm.style.display = 'none';
        segForm.style.display = 'block';
        triForm.style.display = 'none';
    } else {
        circleForm.style.display = 'none';
        rectForm.style.display = 'none';
        segForm.style.display = 'none';
        triForm.style.display = 'block';
    }
}