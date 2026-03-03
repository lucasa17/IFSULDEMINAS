package view;

import model.Employee;
import model.EmployeeFactory;
import model.EmployeeFactory.EmployeeType;

public class Main {

	public static void main(String[] args) {
		Employee brian = EmployeeFactory.create(EmployeeType.PROGRAMMER);
		printEmployee(brian);
		
		brian = EmployeeFactory.create(EmployeeType.LEADER);
		printEmployee(brian);
		
		brian = EmployeeFactory.create(EmployeeType.MANAGER);
		printEmployee(brian);
	}
	
	private static void printEmployee(Employee employee) {
		System.out.println(employee.getPosition() + " " + employee.description() + ".");
	}
}
