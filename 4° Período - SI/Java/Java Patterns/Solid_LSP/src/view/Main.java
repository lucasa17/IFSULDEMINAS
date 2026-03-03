package view;

import model.Rectangle;
import model.Square;

public class Main {

	public static void main(String[] args) {
        Rectangle rect = new Rectangle();
        rect.setWidth(5.0);
        rect.setHeight(10.0);
        
        System.out.println("Área Rectangulo 1: " + rect.getArea());

        // Liskov (onde espera super-classe, 
        // devemos poder passar uma sub-classe)
        rect = new Square();
        rect.setWidth(3.0);
        rect.setHeight(6.0);
        System.out.println("Área Rectangulo 2: " + rect.getArea());
    }
}