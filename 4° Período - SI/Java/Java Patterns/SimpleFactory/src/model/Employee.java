package model;

public abstract class Employee {
	private String position;
	
	public abstract double calculateSalary();

	public String getPosition() {
		return position;
	}

	public void setPosition(String position) {
		this.position = position;
	}
	
	public abstract String description();
}
