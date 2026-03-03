package model.mx;

import model.Employee;
import model.EmployeeReport;
import model.EmployeeType;

public class MXEmployeeReport extends EmployeeReport{
	@Override
	public Employee createEmployee(EmployeeType et) {
		if(et == null) {
			throw new IllegalArgumentException("Tipo do employee inválido");
		}
		if(et == EmployeeType.PROGRAMMER) {
			return new ProgrammerMX();
		}
		if(et == EmployeeType.MANAGER) {
			return new ManagerMX();
		}
		
		throw new IllegalArgumentException("Tipo de employee não suportado");
	}
}
