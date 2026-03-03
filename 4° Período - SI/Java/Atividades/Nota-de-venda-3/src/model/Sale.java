package model;

import java.util.ArrayList;
import java.util.List;

public class Sale {
	private List<SaleItem> items;
	private Payment payment;
	
	public Sale () {
		items = new ArrayList<>();
	}
	
	public boolean addItem (String code, int qtde) {
		Product product;
		try {
			product = new Product(code);
		} catch (IllegalArgumentException e) {
			System.err.println("Erro ao adicionar item: " + e.getMessage());
			return false;
		}

		if (product.getStock() >= qtde) {
			SaleItem saleItem = new SaleItem(product, qtde);
			return items.add(saleItem);
		} else {
			throw new IllegalArgumentException("Estoque baixo");
		}
		
	}
	
	public void finalizeSale() {
		for (SaleItem item : items) {
			Product product = item.getProduct();
			int amountSold = item.getAmount();
			
			int newStock = product.getStock() - amountSold;
			
			DBMock.updateStock(product.getCode(), newStock);
		}
	}
	
	public double getTotalAmount() {
		double totalAmount = 0;
		
		for (SaleItem saleItem : items)
			totalAmount += saleItem.getTotalAmount();
		
		return totalAmount;
	}
	
	public List<SaleItem> getItems() {
		return items;
	}
	
	public void cretePayment(String paymentMethod) {
		payment = DBMock.selectPayment(paymentMethod);
	}
	
	public double valueToBePaid() {
		if (payment == null)
			throw new IllegalStateException("Método de pagamento não definido");
		
		return payment.valueToBePaid(getTotalAmount());
	}
	
	public String paymentMethod() {
		return payment == null ? "" : payment.toString();
	}
}