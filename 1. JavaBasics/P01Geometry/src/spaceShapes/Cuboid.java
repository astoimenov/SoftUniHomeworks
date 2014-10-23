package spaceShapes;

import abstractShapes.*;

public class Cuboid extends SquarePyramid {

    private double depth;

    public Cuboid(Vertex[] vertices, double width, double height, double depth) {
	super(vertices, width, height);
	this.setDepth(depth);
    }

    public double getDepth() {
	return depth;
    }

    public void setDepth(double depth) throws IllegalArgumentException {
	if (depth < 0) {
	    throw new IllegalArgumentException("The depth can't be negative!");
	}

	this.depth = depth;
    }

    @Override
    public double getArea() {
	double area = 2 * (this.width * this.height + this.height * this.depth + this.depth
		* this.width);
	return area;
    }

    @Override
    public double getVolume() {
	double volume = this.width * this.height * this.depth;
	return volume;
    }
}
