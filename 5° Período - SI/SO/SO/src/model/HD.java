package model;

import java.util.Random;

public class HD {
	private int archives;
	private int storage;
	
	public void answerMessage(String name) {
		Random random = new Random();
		int amount = random.nextInt(101); 
		sumStorage(amount);
		archives++;
		System.out.println(name + " com "+ amount +"MB chegou ao HD");
	}

	private void sumStorage(int amount) {
		storage = storage + amount;
	}
	
	@Override
	public String toString() {
		return archives + " arquivo(s) no HD, ocupando " + storage + "MB";
	}
}
