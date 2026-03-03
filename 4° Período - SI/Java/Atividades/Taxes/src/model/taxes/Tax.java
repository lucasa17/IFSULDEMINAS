package model.taxes;

import model.items.Item;

public abstract class Tax {
	public abstract String getName();
	
	public abstract Double calculateTax(Item item);
	
	public boolean equals(Object obj) {
		if(obj == null) {
			return false;
		}
		
		Tax otherTax = null;
		
		try {
			otherTax = (Tax) obj;
		}
		catch(ClassCastException cce){
			return false;
		}
		
		return this.getName().equals(otherTax.getName());
	}
	
}
