package model.mx;

import model.Employee;

public class ProgrammerMX extends Employee{
	public ProgrammerMX() {
		super("Programador", "MXN$");
	}

	@Override
	public double calculateSalary() {
		return 45000;
	}
}
