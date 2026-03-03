package controller;

import model.Product;
import model.Sale;
import model.SaleItem;

public class ControllerSale {
	
	private Sale sale;
	
	public ControllerSale(Sale sale) {
		this.sale = sale;
	}
	
	public void addProduct(String name, double price, int amount) {
		Product product = new Product(name, price);
		SaleItem saleItem = new SaleItem(product, amount);
		sale.addSaleItem(saleItem);
	}

}
