package view;

import java.util.ArrayList;
import java.util.List;

import controller.InVoiceController;
import model.ItemSell;
import model.Product;
import model.Sell;

public class Main {

	public static void main(String[] args) {
		Product product1 = new Product("Feijão", 6.50);
		Product product2 = new Product("Farofa", 7.50);
		Product product3 = new Product("Tomate", 2.50);
		
		ItemSell item1 = new ItemSell(product1, 1);
		ItemSell item2 = new ItemSell(product2, 1);
		ItemSell item3 = new ItemSell(product3, 3);
		
		List<ItemSell> itemsList = new ArrayList();
		itemsList.add(item1);
		itemsList.add(item2);
		itemsList.add(item3);

		Sell sell = new Sell(itemsList);
		
		InVoiceController controller = new InVoiceController();
		controller.showInVoice(controller.createListSelled(itemsList), sell.amountSelled()); 
	}

}
