package model;

public abstract class Employee {
	private String position;
	private String currency;
	
	public Employee(String position, String currency) {
		this.position = position;
		this.currency = currency;
	}

	public String getPosition() {
		return position;
	}

	public String getCurrency() {
		return currency;
	}
	
	public abstract double calculateSalary();
}
