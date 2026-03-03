package view;

import model.IODevice;
import model.MultiFunctionalPrinter;

public class Main {
	
	public static void main(String[] args) {
		String content = "Conteúdo para operação de I/O";
		
		IODevice device = new MultiFunctionalPrinter();

		// Experimente os outros tipo de IODevice
		//device = new Fax();
		//device = new StandardPrinter();
		
		fax(device, content);
		print(device,content);
		scann(device,content);
		xerox(device,content);
	}
	
	private static void fax(IODevice device, String content) {
		device.faxDocument(content);
	}
	
	private static void print(IODevice device, String content) {
		device.printDocument(content);
	}
	
	private static void scann(IODevice device, String content) {
		device.scanDocument(content);
	}
	
	private static void xerox(IODevice device, String content) {
		device.xeroxDocument(content);
	}
}
