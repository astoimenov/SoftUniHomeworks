package spaceShapes;

import abstractShapes.*;

public class Sphere extends SpaceShape {

    private double radius;

    public Sphere(Vertex[] vertices, double radius) {
	super(vertices);
	this.setRadius(radius);
    }

    public double getRadius() {
	return radius;
    }

    public void setRadius(double radius) {
	this.radius = radius;
    }

    @Override
    public double getArea() {
	double area = 4 * Math.PI * this.radius * this.radius;
	return area;
    }

    @Override
    public double getVolume() {
	double volume = (4 * Math.PI * this.radius * this.radius * this.radius) / 3;
	return volume;
    }
}
