package model;

public class Product {
	private String code;
	private String description;
	private double price;
	private int stock; 
	
	public Product(String code) {
		String[] productData = DBMock.selectProduct(code);
		
		if (productData == null)
			throw new IllegalArgumentException(
					"Código inválido " + code);
		
		this.code = code; 
		this.description = productData[0];
		this.price = Double.parseDouble(productData[1]);
		this.stock = Integer.parseInt(productData[2]);
	}
	
	public String getCode() {
		return code;
	}
	
	public String getDescription() {
		return description;
	}
	
	public double getPrice() {
		return price;
	}

	public int getStock() {
		return stock;
	}
}