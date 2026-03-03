package model;

public class Square {
	private double side;
	private String description;
	
	public Square(String description, double side) {
		validateSide(side);
		this.description = description;
		this.side = side;
	}
	public String getDescription() {
		return description;
	}
	
	public double getSide() {
		return side;
	}
	
	public double getRoundedSide() {
		return roundSize(side);
	}
	
	public void setSide(double side) {
		validateSide(side);
		this.side = side;
	}
	
	public double area(){
		return side * side;
	}
	
	private void validateSide(double side) {
		if(side <= 0) {
			throw new IllegalArgumentException("Lado do quadrado não pode ser menor ou igual a zero");
		}
	}
	
	private double roundSize(double side) {
		return Math.round(side);
	}
}
