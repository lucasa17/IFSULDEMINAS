package model;

public enum Country {
	BR("Brasil"),
	US("Estados Unidos"),
	MX("México");
	
	private String name;
	
	private Country(String name) {
		this.name = name;
	}
	
	public String getName() {
		return name;
	}
}
