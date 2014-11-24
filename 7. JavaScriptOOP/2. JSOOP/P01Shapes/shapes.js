var shapesModue = (function () {
    'use strict';

    function Shape(p, color) {
        this._p = p;
        this._color = color;
    }

    Shape.prototype.draw = function () {
        var c = document.getElementById("myCanvas");
        var ctx = c.getContext("2d");
        ctx.strokeStyle = this._color;
        return ctx;
    };

    Shape.prototype.toString = function () {
        var output = this._p + ' ';
        output += 'Color: ' + this._color + ' ';
        return output;
    };

    function Circle(p, color, radius) {
        Shape.call(this, p, color);
        if (typeof radius === 'number') {
            this._radius = radius;
        } else {
            throw 'radius should be a number!';
        }
    }

    Shape.Circle = Circle;
    Circle.prototype = Object.create(Shape.prototype);
    Circle.prototype.constructor = Circle;

    Circle.prototype.draw = function () {
        Shape.prototype.draw.call(this);
        var ctx = Shape.prototype.draw();
        ctx.beginPath();
        ctx.arc(this._p._x, this._p._y, this._radius, 0, 2 * Math.PI);
        ctx.stroke();
        ctx.closePath();
    };

    Circle.prototype.toString = function () {
        var output = 'Circle: ';
        output += Shape.prototype.toString.call(this);
        output += 'Radius: ' + this._radius + ' ';
        return output;
    };

    function Rectangle(p, color, width, height) {
        Shape.call(this, p, color);
        if (typeof width === 'number') {
            this._width = width;
        } else {
            throw 'width should be a number!';
        }

        if (typeof height === 'number') {
            this._height = height;
        } else {
            throw 'height should be a number!';
        }
    }

    Shape.Rectangle = Rectangle;
    Rectangle.prototype = Object.create(Shape.prototype);
    Rectangle.prototype.constructor = Rectangle;

    Rectangle.prototype.draw = function () {
        Shape.prototype.draw.call(this);
        var ctx = Shape.prototype.draw();
        ctx.rect(this._p._x, this._p._y, this._width, this._height);
        ctx.stroke();
    };

    Rectangle.prototype.toString = function () {
        var output = 'Rectangle: ';
        output += Shape.prototype.toString.call(this);
        output += 'Width: ' + this._width + ' ';
        output += 'Height: ' + this._height + ' ';
        return output;
    };

    function Segment(a, color, b) {
        Shape.call(this, a, color);
        this._b = b;
    }

    Shape.Segment = Segment;
    Segment.prototype = Object.create(Shape.prototype);
    Segment.prototype.constructor = Segment;

    Segment.prototype.draw = function () {
        Shape.prototype.draw.call(this);
        var ctx = Shape.prototype.draw();
        ctx.beginPath();
        ctx.moveTo(this._p._x, this._p._y);
        ctx.lineTo(this._b._x, this._b._y);
        ctx.stroke();
        ctx.closePath();
    };

    Segment.prototype.toString = function() {
        var output = 'Segment: ';
        output += Shape.prototype.toString.call(this);
        output += 'a: ' + this._p + ' ';
        output += 'b: ' + this._b + ' ';
        return output;
    };

    function Triangle(a, color, b, c) {
        Segment.call(this, a, color, b);
        this._c = c;
    }

    Shape.Triangle = Triangle;
    Triangle.prototype = Object.create(Segment.prototype);
    Triangle.prototype.constructor = Triangle;

    Triangle.prototype.draw = function () {
        Shape.prototype.draw.call(this);
        var ctx = Shape.prototype.draw();
        ctx.beginPath();
        ctx.moveTo(this._p._x, this._p._y);
        ctx.lineTo(this._b._x, this._b._y);
        ctx.lineTo(this._c._x, this._c._y);
        ctx.lineTo(this._p._x, this._p._y);
        ctx.stroke();
        ctx.closePath();
    };

    Triangle.prototype.toString = function() {
        var output = 'Triangle: ';
        output += Shape.prototype.toString.call(this);
        output += 'a: ' + this._p + ' ';
        output += 'b: ' + this._b + ' ';
        output += 'c: ' + this._c + ' ';
        return output;
    };

    return Shape;
}());