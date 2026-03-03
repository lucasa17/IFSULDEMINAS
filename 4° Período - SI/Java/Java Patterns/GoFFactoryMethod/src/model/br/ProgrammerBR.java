package model.br;

import model.Employee;

public class ProgrammerBR extends Employee{

	public ProgrammerBR() {
		super("Programador", "R$");
	}

	@Override
	public double calculateSalary() {
		return 30000;
	}
}
