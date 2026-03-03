package model.us;

import model.Employee;
import model.EmployeeReport;
import model.EmployeeType;

public class USEmployeeReport extends EmployeeReport{

	@Override
	public Employee createEmployee(EmployeeType et) {
		if(et == null) {
			throw new IllegalArgumentException("Tipo do employee inválido");
		}
		if(et == EmployeeType.PROGRAMMER) {
			return new ProgrammerUS();
		}
		if(et == EmployeeType.MANAGER) {
			return new ManagerUS();
		}
		
		throw new IllegalArgumentException("Tipo de employee não suportado");
	}
}
