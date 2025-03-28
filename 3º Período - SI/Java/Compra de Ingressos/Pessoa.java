package ingressos;

public class Pessoa {
    String nome;
    int idade;
    char sexo;
    String evento;

    // Construtor, getters e setters
    public Pessoa(String nome, int idade, char sexo, String evento) {
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;
        this.evento = evento;
    }

    @Override
    public String toString() {
        return nome + "," + idade + "," + sexo + "," + evento;
    }
}
