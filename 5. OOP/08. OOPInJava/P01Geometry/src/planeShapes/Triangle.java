package planeShapes;

import abstractShapes.*;

public class Triangle extends PlaneShape {

    private double sideA = this.vertices[0].distance(this.vertices[1]);
    private double sideB = this.vertices[1].distance(this.vertices[2]);
    private double sideC = this.vertices[2].distance(this.vertices[0]);

    public Triangle(Vertex[] vertices) {
	super(vertices);
	this.setVertices(vertices);
    }

    @Override
    public void setVertices(Vertex[] vertices) throws IllegalArgumentException {
	if (vertices.length != 3) {
	    throw new IllegalArgumentException(
		    "The triangle should have exactly 3 vertices!");
	}

	this.vertices = vertices;
    }

    @Override
    public double getPerimeter() {
	double perimeter = this.sideA + this.sideB + this.sideC;
	return perimeter;
    }

    @Override
    public double getArea() {
	double halfPerimeter = (this.sideA + this.sideB + this.sideC) / 2;
	double area = Math.sqrt(halfPerimeter * (halfPerimeter - this.sideA)
		* (halfPerimeter - this.sideB) * (halfPerimeter - this.sideC));
	return area;
    }

}
