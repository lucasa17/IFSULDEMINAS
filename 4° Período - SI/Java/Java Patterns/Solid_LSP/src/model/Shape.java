package model;

public abstract class Shape {
	private String description;
	
	public Shape(String description) {
		this.description = description;
	}
	
	public abstract double getArea();
}
