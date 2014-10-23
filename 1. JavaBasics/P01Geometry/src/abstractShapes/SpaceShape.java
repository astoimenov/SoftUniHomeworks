package abstractShapes;

import interfaces.*;

public abstract class SpaceShape extends Shape implements AreaMeasurable,
	VolumeMeasurable {

    public SpaceShape(Vertex[] vertices) {
	super(vertices);
    }

    @Override
    public void setVertices(Vertex[] vertices) {
	for (Vertex vertex : vertices) {
	    if (!vertex.hasZ) {
		throw new IllegalArgumentException("The vertices should be 3D!");
	    }
	}

	this.vertices = vertices;
    }

    @Override
    public String toString() {
	String output = super.toString();
	output += String.format("Area = %.2f\n", this.getArea());
	output += String.format("Volume = %.2f\n", this.getVolume());
	return output;
    }
}
