package testes;

//listar objetos
import java.util.ArrayList;
import java.util.List;

//contas basicas
import java.util.Scanner;

//adicioonar arquivo
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;


public class Testes {

    static void addData(Circulo circulo) {
        
        Scanner scanner = new Scanner(System.in);

        
        System.out.println("Digite a cor do circulo: ");
        String cor = scanner.nextLine();

        System.out.println("Digite o tamanho do círculo (área): ");
        double area = scanner.nextDouble();

        circulo.cor = cor;
        circulo.area = area;
    }

    static void showData(Circulo circulo) {
        
        System.out.println("Cor: " + circulo.cor);
        System.out.println("Área: " + circulo.area);
        
    }

    static void adicionaArquivo(List<Circulo> listaCirculos, String nomeArquivo) {
        
        File arquivo = new File(nomeArquivo);
        
        if (arquivo.exists()) {
            
            try (BufferedReader br = new BufferedReader(new FileReader(arquivo))) {
                
                String linha;
                
                while ((linha = br.readLine()) != null) {
                    
                    String[] campos = linha.split(",");
                    
                    Circulo circulo = new Circulo();
                    circulo.cor = campos[0];
                    circulo.area = Double.parseDouble(campos[1]);
                    
                    listaCirculos.add(circulo);
                }
                
                System.out.println("Dados carregados com sucesso!");
                
            } catch (IOException e) {
                
                System.out.println("Erro ao ler o arquivo: " + e.getMessage());
                
            }
            
        } else {
            
            System.out.println("Arquivo não encontrado :(");
            
        }
    }

    public static void main(String[] args) {
        
        Circulo circulo = new Circulo();
        
        addData(circulo);
        showData(circulo);

        List<Circulo> listaCirculos = new ArrayList<>();
        
        adicionaArquivo(listaCirculos, "arquivo.txt");
    }
}
