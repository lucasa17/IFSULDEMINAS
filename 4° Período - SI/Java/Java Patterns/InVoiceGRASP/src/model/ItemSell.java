package model;

public class ItemSell {
	private Product product;
	private int quantity;
	
	public ItemSell(Product product, int quantity) {
		this.product = product;
		this.quantity = quantity;
	}

	public Product getProduct() {
		return product;
	}

	public int getQuantity() {
		return quantity;
	}

	public double amountValue() {
		return product.getPrice() * quantity;
	}
}
