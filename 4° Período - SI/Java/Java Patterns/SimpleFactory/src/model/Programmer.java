package model;

public class Programmer extends Employee{
	private String role;
	
	Programmer(){
		setPosition("Programador");
		setRole("BackEnd");
	}
	
	public void setRole(String role) {
		this.role = role;
	}

	public String getRole() {
		return role;
	}

	@Override
	public double calculateSalary() {
		return 10.000;
	}

	@Override
	public String description() {
		return getRole();
	}
}
