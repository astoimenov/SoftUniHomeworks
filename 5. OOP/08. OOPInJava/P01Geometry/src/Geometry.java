import java.util.*;
import java.util.stream.Collectors;

import abstractShapes.*;
import interfaces.*;
import planeShapes.*;
import spaceShapes.*;

public class Geometry {

    public static void main(String[] args) {
	Vertex[] vertex2D = new Vertex[] { new Vertex(5, 5) };
	Vertex[] vertices2D = new Vertex[] { new Vertex(0, 1),
		new Vertex(1, 0.5), new Vertex(0.5, 0) };

	Vertex[] vertex3D = new Vertex[] { new Vertex(5, 5, 3.3) };

	Shape[] shapes = new Shape[] { new Triangle(vertices2D),
		new Rectangle(vertex2D, 15, 25.5), new Circle(vertex2D, 16.3),
		new SquarePyramid(vertex3D, 5.7, 3.2),
		new Cuboid(vertex3D, 12, 14, 3), new Sphere(vertex3D, 3.14) };

	List<Shape> spaceShapes = (List<Shape>) Arrays.asList(shapes).stream()
		.filter(s -> s instanceof VolumeMeasurable)
		.filter(v -> ((VolumeMeasurable) v).getVolume() > 40)
		.collect(Collectors.toList());
	System.out.println("Space shapes (volume > 40):");
	for (Shape shape : spaceShapes) {
	    System.out.print(shape.toString());
	}

	Comparator<Shape> perimeterComparator = (Shape s1, Shape s2) -> Double
		.compare(((PlaneShape) s1).getPerimeter(),
			((PlaneShape) s1).getPerimeter());
	List<Shape> planeShapes = (List<Shape>) Arrays.asList(shapes).stream()
		.filter(s -> s instanceof PerimeterMeasurable)
		.sorted(perimeterComparator).collect(Collectors.toList());

	System.out.println();
	System.out.println("Plane shapes (sorted):");
	for (Shape shape : planeShapes) {
	    System.out.print(shape.toString());
	}
    }

}
