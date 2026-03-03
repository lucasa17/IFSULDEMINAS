package model;

public class Leader extends Employee{

	private String area;
	
	Leader(){
		setPosition("Líder Tecnico");
		setArea("Líder JAVA");
	}
	
	public String getArea() {
		return area;
	}

	public void setArea(String area) {
		this.area = area;
	}

	@Override
	public double calculateSalary() {
		return 12.000;
	}

	@Override
	public String description() {
		return getArea();
	}
	
}
