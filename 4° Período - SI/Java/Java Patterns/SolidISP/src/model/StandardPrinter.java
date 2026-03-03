package model;

public class StandardPrinter implements PrintDevice {

	@Override
	public void printDocument(String content) {
		System.out.println("SP: Imprimindo documento: \n" + content);
	}

}
