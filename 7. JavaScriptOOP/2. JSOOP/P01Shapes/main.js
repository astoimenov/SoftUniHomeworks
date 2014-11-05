'use strict';

var Shape = shapesModue;
var Point = pointModule;

var point = new Point(0, 0);
var rect = new Shape.Rectangle(point, '#00f', 50, 50);
rect.draw();

var p2 = new Point(30, 30);
var circle = new Shape.Circle(p2, '#f00', 15);
circle.draw();

var seg = new Shape.Segment(point, '#abc951', p2);
seg.draw();

var a = new Point(60, 50);
var b = new Point(25, 10);
var c = new Point(30, 60);
var tr = new Shape.Triangle(a, '#095', b, c);
tr.draw();

var shapes = [point, p2, circle, rect, seg, tr];
var shapesSelect = document.getElementById('shapes');
for (var i = 0; i < shapes.length; i++) {
    var shapeOption = document.createElement('option');
    shapesSelect.appendChild(shapeOption);
    shapeOption.innerHTML = shapes[i].toString();
}