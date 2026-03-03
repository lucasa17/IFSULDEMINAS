package model.taxes;

import model.items.Item;
import model.items.Product;
import model.persistence.DataBaseMock;

public class IPI extends Tax{
	private String segment;
	
	@Override
	public String getName() {
		return "IPI";
	}

	@Override
	public Double calculateTax(Item item) {		
		Product product = null;
		
		try {
			product = (Product) item;
		}
		catch(ClassCastException cce) {
			throw new IllegalStateException("Item inválido para IPI");
		}
		
		Double taxPercentage = DataBaseMock.selectIPI(segment);
		
		return (product.getCost() + product.getInsurance() + product.getShipping()) * taxPercentage;
	}

}
