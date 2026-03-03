package model;

import model.br.BREmployeeReport;
import model.mx.MXEmployeeReport;
import model.us.USEmployeeReport;

public class EmployeeReportFactory {
	public static EmployeeReport createEmployeeReport(Country country) {
		if(country == null) {
			throw new IllegalArgumentException("País inválido");
		}
		if(country == Country.BR) {
			return new BREmployeeReport();
		}
		if(country == Country.US) {
			return new USEmployeeReport();
		}
		if(country == Country.MX) {
			return new MXEmployeeReport();
		}
		
		throw new IllegalArgumentException("País não suportado");

	}
}
