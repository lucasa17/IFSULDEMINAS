package model.mx;

import model.Employee;

public class ManagerMX extends Employee{
	public ManagerMX() {
		super("Gerente", "MXN$");
	}
	@Override
	public double calculateSalary() {
		return 60000;
	}
}
