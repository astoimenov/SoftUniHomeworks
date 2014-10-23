package planeShapes;

import abstractShapes.*;

public class Circle extends PlaneShape {

    private double radius;

    public Circle(Vertex[] vertices, double radius) {
	super(vertices);
	this.setRadius(radius);
    }

    public double getRadius() {
	return radius;
    }

    public void setRadius(double radius) throws IllegalArgumentException {
	if (radius < 0) {
	    throw new IllegalArgumentException("The radius can't be negative!");
	}

	this.radius = radius;
    }

    @Override
    public double getPerimeter() {
	double perimeter = 2 * Math.PI * this.radius;
	return perimeter;
    }

    @Override
    public double getArea() {
	double area = Math.PI * this.radius * this.radius;
	return area;
    }

}
