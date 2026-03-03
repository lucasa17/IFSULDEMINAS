package model.br;

import model.Employee;
import model.EmployeeReport;
import model.EmployeeType;

public class BREmployeeReport extends EmployeeReport{

	@Override
	public Employee createEmployee(EmployeeType et) {
		if(et == null) {
			throw new IllegalArgumentException("Tipo do employee inválido");
		}
		if(et == EmployeeType.PROGRAMMER) {
			return new ProgrammerBR();
		}
		if(et == EmployeeType.MANAGER) {
			return new ManagerBR();
		}
		
		throw new IllegalArgumentException("Tipo de employee não suportado");
	}

}
