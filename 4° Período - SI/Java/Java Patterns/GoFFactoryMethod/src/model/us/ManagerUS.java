package model.us;

import model.Employee;

public class ManagerUS extends Employee{

	public ManagerUS() {
		super("Manager", "US$");
	}
	@Override
	public double calculateSalary() {
		return 300000/12;
	}
	
}
