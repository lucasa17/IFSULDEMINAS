package controller;

import java.util.ArrayList;
import java.util.List;

import model.ItemSell;

public class InVoiceController {
	
	public List<String> createListSelled(List<ItemSell> items){
		List<String> itemsSelled = new ArrayList();
		for(ItemSell i : items) {
			String resume = i.getProduct().getName() + "  |  " + i.getProduct().getPrice() + "      |    " + i.getQuantity() + "       |    " + i.amountValue() + "\n";
			itemsSelled.add(resume);
		}
		
		return itemsSelled;
	}
	
	public void showInVoice(List<String> itemsSelled, double totalValue) {
		System.out.println("Produto | Valor(un) | Quantidade |   Total");
		for(String i : itemsSelled) {
			System.out.println(i);
		}
		System.out.println("Total vendido: "  + totalValue);
	}
}
