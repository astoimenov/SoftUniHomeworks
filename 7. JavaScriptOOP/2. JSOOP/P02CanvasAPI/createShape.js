function createShape() {
    var shapeOption = document.getElementById('shape');
    var shape = shapeOption.options[shapeOption.selectedIndex].value;
    console.log(shape);
    if (shape) {
        var Shape = shapesModue;
        var Point = pointModule;

        var x = parseInt(document.getElementById('x').value);
        var y = parseInt(document.getElementById('y').value);
        var color = document.getElementById('color').value;

        var p = new Point(x, y);

        if (shape === 'circle') {
            var radius = parseInt(document.getElementById('radius').value);
            var circle = new Shape.Circle(p, color, radius);
            circle.draw();
            displayShapesInfo(circle);
        } else if (shape === 'rectangle') {
            var width = parseInt(document.getElementById('width').value);
            var height = parseInt(document.getElementById('height').value);
            var rect = new Shape.Rectangle(p, color, width, height);
            rect.draw();
            displayShapesInfo(rect);
        } else if (shape === 'segment') {
            var x2 = parseInt(document.getElementById('sbX').value);
            var y2 = parseInt(document.getElementById('sbY').value);
            var p2 = new Point(x2, y2);
            var segment = new Shape.Segment(p, color, p2);
            segment.draw();
            displayShapesInfo(segment);
        } else {
            var bX = parseInt(document.getElementById('bX').value);
            var bY = parseInt(document.getElementById('bY').value);
            var cX = parseInt(document.getElementById('cX').value);
            var cY = parseInt(document.getElementById('cY').value);
            var b = new Point(bX, bY);
            var c = new Point(cX, cY);
            var triangle = new Shape.Triangle(p, color, b, c);
            triangle.draw();
            displayShapesInfo(triangle);
        }
    }
}

function displayShapesInfo(shape) {
    var shapesInfo = document.getElementById('shapesInfo');
    shapesInfo.style.display = 'block';
    var shapesSelect = document.getElementById('shapes');
    var shapeOpt = document.createElement('option');
    shapesSelect.appendChild(shapeOpt);
    shapeOpt.innerHTML = shape.toString();
}