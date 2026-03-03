package model;

public class Pix implements Payment{
	private double discount;
	
	public Pix(double discount) {
		this.discount = discount/100;
	}
	
	@Override
	public double valueToBePaid(double value) {
		return value - (discount*value);
	}
	
	public String toString() {
		return "Pix";
	}

}
