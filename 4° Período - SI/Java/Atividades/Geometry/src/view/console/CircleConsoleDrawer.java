package view.console;

import model.Circle;

public class CircleConsoleDrawer {
	private Circle circle;
	
	public CircleConsoleDrawer(Circle circle) {
		if(circle == null) {
			throw new IllegalArgumentException("É necessário uma instância válida de Circle");
		}
		this.circle = circle; 
	}
	
	public void draw() {
		 for (int y = (int) -(Math.round(circle.getRadius())); y <= Math.round(circle.getRadius()); y++) {
            for (int x = (int) -(Math.round(circle.getRadius())); x <= Math.round(circle.getRadius()); x++) {
                if (x * x + y * y <= Math.round(circle.getRadius()) * Math.round(circle.getRadius())) {
                    System.out.print("*");
                } else {
                    System.out.print(" ");
                }
            }
            System.out.println();
        }
	}
}
