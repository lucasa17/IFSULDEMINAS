package model;

public class Manager extends Employee{
	private int employees;
	
	Manager(){
		setPosition("Gerente");
		setEmployees(10);
	}

	public int getEmployees() {
		return employees;
	}

	public void setEmployees(int employees) {
		this.employees = employees;
	}

	@Override
	public double calculateSalary() {
		return 15.000 + (500 * employees);
	}

	@Override
	public String description() {
		return "com " + employees + " subordinados";
	}
}
