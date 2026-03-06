package model;

import java.util.Random;

public class RAM {
	private int ramAmount;

	public void answerMessage(String name) {
		Random random = new Random();
		int amount = random.nextInt(101); 
		sumRam(amount);
		System.out.println(amount + "MB de Memória RAM foi alocada para " + name);
	}
	
	private void sumRam(int amount) {
		ramAmount = ramAmount + amount;
	}
	
	@Override
	public String toString() {
		return ramAmount + "MB de RAM sendo utilizada";
	}
}
