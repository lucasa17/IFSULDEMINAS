package model;

public class Fax implements FaxDevice {

	@Override
	public void faxDocument(String content) {
		System.out.println("FX: Enviando documento: \n" + content);
	}

}
