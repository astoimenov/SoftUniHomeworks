package abstractShapes;

import interfaces.*;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable,
	AreaMeasurable {

    public PlaneShape(Vertex[] vertices) {
	super(vertices);
    }

    @Override
    public void setVertices(Vertex[] vertices) throws IllegalArgumentException {
	for (Vertex vertex : vertices) {
	    if (vertex.hasZ) {
		throw new IllegalArgumentException("The vertices should be 2D!");
	    }
	}

	this.vertices = vertices;
    }

    @Override
    public String toString() {
	String output = super.toString();
	output += String.format("Area = %.2f\n", this.getArea());
	output += String.format("Perimeter = %.2f\n", this.getPerimeter());
	return output;
    }
}
