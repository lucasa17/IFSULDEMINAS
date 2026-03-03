package model.persistence;

import java.util.HashMap;
import java.util.Map;

public class DataBaseMock {
	private static Map<String, Double> ipis = new HashMap<>();
	private static Map<String, Double> icmss = new HashMap<>();
	private static Map<String, Double> isss = new HashMap<>();
	
	private static final Double IPI_DEFAULT = 0.15;
	private static final Double ICMS_DEFAULT = 0.01;
	private static final Double ISS_DEFAULT = 0.05;

	
	static {
		ipis.put("auto", 0.18);
		ipis.put("food", 0.05);
		ipis.put("drink", 0.25);
		
		icmss.put("SP-MG", 0.03);
		icmss.put("RJ-MG", 0.05);
		icmss.put("ES-MG", 0.08);
		
		isss.put("campos gerais", 0.08);
		isss.put("machado", 0.05);
		isss.put("alfenas", 0.10);
	}
	
	public static Double selectIPI(String productType) {
		Double ipi = ipis.get(productType);
		
		return ipi != null ? ipi : IPI_DEFAULT;
	}
	
	public static Double selectICMS(String from, String to) {
		Double icms = icmss.get(from + "-" + to);

		return icms != null ? icms : ICMS_DEFAULT;
	}
	
	public static Double selectISS(String city) {
		Double iss = icmss.get(city);

		return iss != null ? iss : ISS_DEFAULT;
	}
}
