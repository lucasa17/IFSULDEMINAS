package view.console;

import model.Triangle;

public class TriangleConsoleDrawer {

	private Triangle triangle;
	
	public TriangleConsoleDrawer( Triangle triangle) {
		if(triangle == null) {
			throw new IllegalArgumentException("É necessário uma instância válida de Triangle");
		}
		this.triangle = triangle; 
	}
	
	public void draw() {
		for (int i = 1; i <= Math.round(triangle.getHeight()); i++) {
    	    for (int j = 1; j <= i; j++) {
    	        System.out.print("*");
    	    }
    	    System.out.println();
    	}
	}
}
