package view;

import java.util.Scanner;

import model.Rectangle;
import model.Square;
import model.Triangle;
import model.Circle;

import view.console.RectangleConsoleDrawer;
import view.console.SquareConsoleDrawer;
import view.console.TriangleConsoleDrawer;
import view.console.CircleConsoleDrawer;

public class Main {
	
	static Scanner scanner = new Scanner(System.in);

	static void menu(){
		System.out.println("Menu:");
		System.out.println("1 - Quadrado\n2 - Retângulo\n3 - Triângulo\n4 - Círculo\n");
		System.out.print("Escolha uma opção: ");
		int option = scanner.nextInt(); 
		
		switch(option) {
			case 1:
				Square square1 = new Square("Q1", 10);
				System.out.printf("%s, área: %.2f", square1.getDescription(), square1.area());
				System.out.println("\nDesenho: ");
				SquareConsoleDrawer squareConsoleDrawer = new SquareConsoleDrawer(square1);
				squareConsoleDrawer.draw();
				
				square1.setSide(5);
				System.out.printf("%s, área: %.2f", square1.getDescription(), square1.area());
				System.out.println("\nDesenho: ");
				squareConsoleDrawer.draw();
		    break;
			case 2:
				Rectangle rectangle1 = new Rectangle("R1", 10, 5);
				System.out.printf("%s, área: %.2f", rectangle1.getDescription(), rectangle1.area());
				System.out.println("\nDesenho: ");
				RectangleConsoleDrawer rectangleConsoleDrawer = new RectangleConsoleDrawer(rectangle1);
				rectangleConsoleDrawer.draw();
				
				rectangle1.setHeight(5);
				rectangle1.setBase(10);
				System.out.printf("%s, área: %.2f", rectangle1.getDescription(), rectangle1.area());
				System.out.println("\nDesenho: ");
				rectangleConsoleDrawer.draw();
			break;
			case 3:
				Triangle triangle1 = new Triangle("T1", 10, 5);
				System.out.printf("%s, área: %.2f", triangle1.getDescription(), triangle1.area());
				System.out.println("\nDesenho: ");
				TriangleConsoleDrawer triangleConsoleDrawer = new TriangleConsoleDrawer(triangle1);
				triangleConsoleDrawer.draw();
				
				triangle1.setHeight(5);
				triangle1.setBase(10);
				System.out.printf("%s, área: %.2f", triangle1.getDescription(), triangle1.area());
				System.out.println("\nDesenho: ");
				triangleConsoleDrawer.draw();
			break;
			case 4:
				Circle circle1 = new Circle("C1", 10);
				System.out.printf("%s, área: %.2f", circle1.getDescription(), circle1.area());
				System.out.println("\nDesenho: ");
				CircleConsoleDrawer circleConsoleDrawer = new CircleConsoleDrawer(circle1);
				circleConsoleDrawer.draw();
				
				circle1.setRadius(5);
				System.out.printf("%s, área: %.2f", circle1.getDescription(), circle1.area());
				System.out.println("\nDesenho: ");
				circleConsoleDrawer.draw();
			break;
			default:
		        System.out.println("Valor inválido");
			break;
		}
	}
	public static void main(String [] args) {
		
		menu();

	}
}
