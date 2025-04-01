import java.time.LocalDate;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Digite o tamanho inicial da pilha: ");
        int tamanhoInicial = scanner.nextInt();
        PilhaDeRecordes pilha = new PilhaDeRecordes(tamanhoInicial);

        while (true) {
            System.out.println("\nMenu:");
            System.out.println("1. Adicionar recorde");
            System.out.println("2. Consultar recorde do topo");
            System.out.println("3. Remover recorde do topo");
            System.out.println("4. Listar todos os recordes");
            System.out.println("5. Sair");
            System.out.print("Escolha uma opção: ");
            int opcao = scanner.nextInt();
            scanner.nextLine(); // Consumir a nova linha

            switch (opcao) {
                case 1:
                    System.out.print("Digite a data do recorde (AAAA-MM-DD): ");
                    LocalDate data = LocalDate.parse(scanner.nextLine());
                    System.out.print("Digite o tempo do recorde: ");
                    double tempo = scanner.nextDouble();
                    scanner.nextLine(); // Consumir a nova linha
                    System.out.print("Digite o nome do atleta: ");
                    String nome = scanner.nextLine();
                    Recorde recorde = new Recorde(data, tempo, nome);
                    pilha.empilhar(recorde);
                    break;
                case 2:
                    Recorde recordeTopo = pilha.topo();
                    if (recordeTopo != null) {
                        System.out.println("Recorde do topo: " + recordeTopo);
                    } else {
                        System.out.println("A pilha está vazia.");
                    }
                    break;
                case 3:
                    Recorde recordeRemovido = pilha.desempilhar();
                    if (recordeRemovido != null
