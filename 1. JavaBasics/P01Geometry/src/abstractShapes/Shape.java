package abstractShapes;

public abstract class Shape {
    protected Vertex[] vertices;

    public Shape(Vertex[] vertices) {
	this.setVertices(vertices);
    }

    public Vertex[] getVertices() {
	return vertices;
    }

    public void setVertices(Vertex[] vertices) {
	this.vertices = vertices;
    }

    @Override
    public String toString() {
	String output = this.getClass().getSimpleName() + "\n";
	output += "Vertices: [";
	for (Vertex vertex : this.vertices) {
	    output += vertex.toString();
	}

	output += "]\n";
	return output;
    }
}
