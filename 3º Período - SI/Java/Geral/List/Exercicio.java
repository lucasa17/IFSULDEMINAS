package exercicio;

import java.util.Scanner;

import java.io.BufferedReader;
import java.io.BufferedWriter;

import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

import java.util.ArrayList;
import java.util.List;

public class Exercicio {

    
    static void adicionaPessoa(List<Pessoa> listaPessoas){
        
        Pessoa novaPessoa = new Pessoa(); 

        Scanner scanner = new Scanner(System.in);
                
        System.out.print("Digite o nome da pessoa: ");
        novaPessoa.nome = scanner.nextLine();
        
        System.out.print("Digite sua idade: ");
        novaPessoa.idade = scanner.nextInt();

        System.out.print("Digite seu sexo(F/M): ");
        novaPessoa.sexo = scanner.next().charAt(0);
        
        listaPessoas.add(novaPessoa);

    }
    
    
     static void mostraPessoa(List<Pessoa> listaPessoas) {
         
        for (Pessoa p : listaPessoas) {
            
            System.out.println("Nome: " + p.nome + "\tIdade: " + p.idade + "\tSexo: " + p.sexo);
            
        }
    }
   
     
    public static void salvarDados(List<Pessoa> listaPessoas, String nomeArquivo) {
    
        try (BufferedWriter writer = new BufferedWriter(new FileWriter(nomeArquivo))) {
            
            for (Pessoa p : listaPessoas) {
                        
            writer.write(p.nome + "," + p.idade + "," + p.sexo);
 
        }
            
            System.out.println("Dados salvos com sucesso!");
            
        } catch (IOException e) {
            
            System.out.println("Erro ao salvar os dados: " + e.getMessage());
            
        }
    }
    
    
    public static void carregarDados(List<Pessoa> listaPessoas, String nomeArquivo) {
        
        File arquivo = new File(nomeArquivo);

        if (arquivo.exists()) {
            
            try (BufferedReader reader = new BufferedReader(new FileReader(arquivo))) {
                
                String linha;
                
                while ((linha = reader.readLine()) != null) {
                    
                    String[] campos = linha.split(",");
                    
                    if (campos.length == 3) {
                        
                        Pessoa novaPessoa = new Pessoa();
                        novaPessoa.nome = campos[0];
                        novaPessoa.idade = Integer.parseInt(campos[1]);
                        novaPessoa.sexo = campos[2].charAt(0);
                        
                        listaPessoas.add(novaPessoa);
                        
                    }
                }
                
                System.out.println("Dados carregados com sucesso!");
                
            } catch (IOException e) {
                System.out.println("Erro ao ler o arquivo: " + e.getMessage());
                
            } catch (NumberFormatException e) {
                System.out.println("Erro: formato inválido nos dados do arquivo.");
                
            }
            
        } else {
            
            System.out.println("Arquivo não encontrado :(");
            
        }
    }
    
    
    static void adicionaArquivo(List<Pessoa> listaPessoas, String nomeArquivo) {
        
        File arquivo = new File(nomeArquivo);
        
        if (arquivo.exists()) {
            
            try (BufferedReader br = new BufferedReader(new FileReader(arquivo))) {
                
                String linha;
                
                while ((linha = br.readLine()) != null) {
                    
                    String[] campos = linha.split(",");
                    
                    Pessoa novaPessoa = new Pessoa();
                    
                    novaPessoa.nome = campos[0];
                    novaPessoa.idade = Integer.parseInt(campos[1]);
                    novaPessoa.sexo = campos[2].charAt(0);
                    
                    listaPessoas.add(novaPessoa);
                }
                
                System.out.println("Dados carregados com sucesso!");
                
            } catch (IOException e) {
                
                System.out.println("Erro ao ler o arquivo: " + e.getMessage());
                
            }
            
        } else {
            
            System.out.println("Arquivo não encontrado :(");
            
        }
    }
    
    
    static int menu()
        {

            Scanner scanner = new Scanner(System.in);

            System.out.println("\n------------------Menu------------------");
            System.out.println("1 - Cadastrar pessoa");
            System.out.println("2 - Mostrar bandas");
            System.out.println("3 - Adicione um arquivo");
            System.out.println("0 - Sair");
            
            
            System.out.print("\nEscolha uma opção: ");
            int op = scanner.nextInt();

            return op;
        }

    public static void main(String[] args) {

       Scanner scanner = new Scanner(System.in);

       List<Pessoa> listaPessoas = new ArrayList<>();
       

       carregarDados(listaPessoas, "pessoas.txt");
       
       int op;
       
       do{
           
                op = menu();
           
                switch (op){

                    case 1:

                        adicionaPessoa(listaPessoas);

                    break;

                    case 2:

                        mostraPessoa(listaPessoas);

                    break;
                    
                     case 3:

                        System.out.println("Digite o nome do arquivo (inclua .txt): ");
                        String nomeArq = scanner.nextLine();

                        adicionaArquivo(listaPessoas, nomeArq);

                    break;
                    
                    case 0:

                        salvarDados(listaPessoas, "pessoas.txt");
                        System.out.println("Saindo.....");

                        break;

                    default:
                    
                        System.out.println("Essa opção não existe");

                    break;
                }
                        
       
       } while (op != 0);
       
       }
}
