package model;

import model.RAM;
import model.CPU;
import model.HD;

public class Hardware implements Kernel{
	RAM ram = new RAM();
	CPU cpu = new CPU();
	HD hd = new HD();

	@Override
	public void memoryManager(String name) {
		ram.answerMessage(name);
		System.out.println(ram.toString());
	}

	@Override
	public void processManager(String name) {
		cpu.answerMessage(name);
	}

	@Override
	public void archiveManager(String name) {
		hd.answerMessage(name);
		System.out.println(hd.toString());
	}
	
}
