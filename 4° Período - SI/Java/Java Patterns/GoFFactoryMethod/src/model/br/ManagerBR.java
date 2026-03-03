package model.br;

import model.Employee;

public class ManagerBR extends Employee{
	
	public ManagerBR() {
		super("Gerente", "R$");
	}
	@Override
	public double calculateSalary() {
		return 20000;
	}
}
