package view;

import java.util.Scanner;
import model.Hardware;

public class Main {
	
	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		Hardware hardware = new Hardware();
		
		int i = 1;
		while(i != 0) {
			System.out.println("Escolha uma ação: ");
			System.out.println("1 - Salvar Arquivo");
			System.out.println("2 - Abrir um programa");
			System.out.println("0 - Sair");
	
			int op = scanner.nextInt();
			
			switch (op) {
			    case 1:
			    	String archive = "Arquivo " + i;
			        hardware.processManager(archive);
			        hardware.archiveManager(archive);
			        break;

			    case 2:
			    	String program = "programa " + i;
			        hardware.processManager("Abertura do " + program);
			        hardware.memoryManager("Abertura do " + program);
			        break;
			        
			    case 0:
			        i = 0;
			        System.out.println("\nSistema encerrado");
			        break;
	
			    default:
			        System.out.println("Opção inválida!");
			        break;
			}
			System.out.println("\n");
			i++;
		}
	}
}