package model;

public class Rectangle extends Shape{

	private Double width;
	private Double length;
	
	public Rectangle( String description, double length, double width) {	
		super(description);
		this.width = width;
		this.length = length;
	}

	public Double getWidth() {
		return width;
	}

	public Double getLength() {
		return length;
	}

	@Override
	public double getArea() {
		return width * length;
	}
}