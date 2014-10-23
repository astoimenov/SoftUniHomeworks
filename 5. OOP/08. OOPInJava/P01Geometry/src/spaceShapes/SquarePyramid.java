package spaceShapes;

import abstractShapes.*;

public class SquarePyramid extends SpaceShape {

    protected double width;
    protected double height;

    public SquarePyramid(Vertex[] vertices, double width, double height) {
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
		    "The Pyramid should have exactly 1 vertex!");
	}

	this.vertices = vertices;
    }

    @Override
    public double getVolume() {
	double volume = (this.width * this.width * this.height) / 3;
	return volume;
    }

    @Override
    public double getArea() {
	double widthPowTwo = this.width * this.width;
	double area = widthPowTwo
		+ this.width
		* Math.sqrt(widthPowTwo + (2 * this.height) * (2 * this.height));
	return area;
    }
}
