package model;

public class Circle {
	private double radius;
	private String description;

	
	public Circle(String description, double radius) {
		validateSize(radius);
		this.description = description;
		this.radius = radius;
	}
	
	public String getDescription() {
		return description;
	}
	
	public double getRadius() {
		return radius;
	}
	
	public void setRadius(double radius) {
		validateSize(radius);
		this.radius = radius;
	}
	
	public double area(){
		return Math.PI * Math.pow(radius, 2);
	}
	
	private void validateSize(double size) {
		if(size <= 0) {
			throw new IllegalArgumentException("Base ou altura do triângulo não pode ser menor ou igual a zero");
		}
	}
}
