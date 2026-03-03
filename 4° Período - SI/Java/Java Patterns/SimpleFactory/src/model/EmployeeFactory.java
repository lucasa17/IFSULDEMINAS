package model;

public class EmployeeFactory {
	
	public enum EmployeeType{
		MANAGER,
		PROGRAMMER,
		LEADER
	}
	
	public static Employee create(EmployeeType type) {
		if(type == null) {
			throw new IllegalArgumentException("Tipo nulo");
		}
		
		if(type == EmployeeType.MANAGER) {
			return new Manager();
		}
		
		if(type == EmployeeType.PROGRAMMER) {
			return new Programmer();
		}
		
		if(type == EmployeeType.LEADER) {
			return new Leader();
		}
		
		throw new IllegalArgumentException("Tipo inválido");
	}
}
