package view;

import model.Country;
import model.EmployeeReport;
import model.EmployeeReportFactory;
import model.EmployeeType;

public class Main {

	public static void main(String[] args) {
		report(Country.BR);
		report(Country.US);
		report(Country.MX);
	}
	
	public static void report(Country country) {
		System.out.println("\nRelatório RH "+ country.getName());
		
		EmployeeReport employeeReport = EmployeeReportFactory.createEmployeeReport(country);
		
		String managerData= employeeReport.reportData(EmployeeType.MANAGER);
		String programmerData= employeeReport.reportData(EmployeeType.PROGRAMMER);
				
		System.out.println(managerData);
		System.out.println(programmerData);

	}

}
