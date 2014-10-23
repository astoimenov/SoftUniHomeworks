package planeShapes;

import abstractShapes.*;

public class Rectangle extends PlaneShape {

    private double width;
    private double height;

    public Rectangle(Vertex[] vertices, double width, double height) {
	super(vertices);
	this.setWidth(width);
	this.setHeight(height);
    }

    public double getWidth() {
	return width;
    }

    public void setWidth(double width) throws IllegalArgumentException {
	if (width < 0) {
	    throw new IllegalArgumentException("The width can't be negative!");
	}

	this.width = width;
    }

    public double getHeight() {
	return height;
    }

    public void setHeight(double height) throws IllegalArgumentException {
	if (height < 0) {
	    throw new IllegalArgumentException("The height can't be negative!");
	}

	this.height = height;
    }

    @Override
    public void setVertices(Vertex[] vertices) throws IllegalArgumentException {
	if (vertices.length != 1) {
	    throw new IllegalArgumentException(
		    "The rectangle should have exactly 1 vertex!");
	}

	this.vertices = vertices;
    }

    @Override
    public double getPerimeter() {
	double perimeter = 2 * this.width + 2 * this.height;
	return perimeter;
    }

    @Override
    public double getArea() {
	double area = this.width * this.height;
	return area;
    }
}
