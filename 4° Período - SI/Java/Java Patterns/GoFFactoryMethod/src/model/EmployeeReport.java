package model;

import model.br.ManagerBR;

public abstract class EmployeeReport {
	
	public String reportData(EmployeeType et) {
		Employee employee = createEmployee(et);
		
		String employeeData = String.format("%s \n%s:%.2f", employee.getPosition(), employee.getCurrency(), employee.calculateSalary());
		
		return employeeData;
	}
	
	public abstract Employee createEmployee(EmployeeType et);
	
}
