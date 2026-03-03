package model.items;

public class Product extends Item{
	private Double shipping;
	private Double insurance;
	
	public Product(String name, Double cost, Double shipping, Double insurance) {
		super(name, cost);
		
		this.insurance = insurance;
		this.shipping = shipping;
	}
	
	public Double getShipping() {
		return shipping;
	}
	public Double getInsurance() {
		return insurance;
	}

	@Override
	public Double calculateFinalPrice() {
		// TODO Auto-generated method stub
		return null;
	}
}
