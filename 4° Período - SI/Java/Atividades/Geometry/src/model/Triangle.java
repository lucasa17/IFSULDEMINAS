package model;

public class Triangle {

	private double base;
	private double height;
	private String description;
	
	public Triangle(String description, double base, double height){
		validateSize(base);
		validateSize(height);
		this.description = description;
		this.base = base;
		this.height = height;
	}
	
	public String getDescription() {
		return description;
	}
	
	public double getBase() {
		return base;
	}
	
	public double getHeight() {
		return height;
	}
	
	public void setBase(double base) {
		validateSize(base);
		this.base = base;
	}
	
	public void setHeight(double height) {
		validateSize(height);
		this.height = height;
	}
	
	public double area(){
		return base * height;
	}
	
	private void validateSize(double size) {
		if(size <= 0) {
			throw new IllegalArgumentException("Base ou altura do triângulo não pode ser menor ou igual a zero");
		}
	}
}

