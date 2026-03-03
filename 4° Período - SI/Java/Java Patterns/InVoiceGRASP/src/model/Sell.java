package model;

import java.util.List;

public class Sell {
	private List<ItemSell> sells;
	
	public Sell(List<ItemSell> sells) {
		this.sells = sells;
	}

	public List<ItemSell> getISells() {
		return sells;
	}

	public double amountSelled() {
		double value = 0;
		for(ItemSell s : sells) {
			value += s.amountValue();
		}
		return value;
	}
	
}
