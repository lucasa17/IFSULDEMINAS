package view;

import controller.ControllerSale;
import model.Sale;
import model.SalePresenter;

public class Main {

	public static void main(String[] args) {
		
		Sale sale = new Sale();
		
		ControllerSale controller = new ControllerSale(sale);
		
		controller.addProduct("Feijão", 6.50, 1);
		controller.addProduct("Farofa", 7.50, 1);
		controller.addProduct("Tomate", 2.50, 3);

		SalePresenter presenter = new ConsoleSalePresenter();
		
		presenter.show(sale);
	}
}
