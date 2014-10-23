package abstractShapes;

public class Vertex {
    private double x;
    private double y;
    private double z;
    protected boolean hasZ;

    public Vertex(double x, double y) {
	this.setX(x);
	this.setY(y);
    }

    public Vertex(double x, double y, double z) {
	this(x, y);
	this.setZ(z);
	this.hasZ = true;
    }

    public double getX() {
	return x;
    }

    public void setX(double x) {
	this.x = x;
    }

    public double getY() {
	return y;
    }

    public void setY(double y) {
	this.y = y;
    }

    public double getZ() {
	return z;
    }

    public void setZ(double z) {
	this.z = z;
    }

    public double distance(Vertex vertex) throws IllegalArgumentException {
	if (this.hasZ && vertex.hasZ) {
	    return Math.sqrt(Math.pow(this.getX() - vertex.getX(), 2)
		    + Math.pow(this.getY() - vertex.getY(), 2)
		    + Math.pow(this.getZ() - vertex.getZ(), 2));
	} else if (!(this.hasZ && vertex.hasZ)) {
	    return Math.sqrt(Math.pow(this.getX() - vertex.getX(), 2)
		    + Math.pow(this.getY() - vertex.getY(), 2));
	} else {
	    throw new IllegalArgumentException(
		    "The point must have the same measurement");
	}
    }

    @Override
    public String toString() {
	String output = "(";
	output += this.x + ", " + this.y;
	if (hasZ) {
	    output += ", " + this.z;
	}

	output += ")";
	return output;
    }
}
