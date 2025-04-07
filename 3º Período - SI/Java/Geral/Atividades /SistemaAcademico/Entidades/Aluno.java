package Entidades;

public class Aluno {
    
    private String nome;
    private Integer matricula;
    private double nota;
    
    public Aluno(){
        this.nome = "Yasmin";
        this.matricula = 100;
        this.nota = 8.50;
    }
    
    public Aluno(String nome, int matricula, double nota){
        this.nome = nome;
        this.matricula = matricula;
        this.nota = nota;
    }
    
    public String getNome(){
        return nome;
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public Integer getMatricula(){
        return matricula;
    }
    
    public void setMatricula(Integer matricula){
        this.matricula = matricula;
    }
    
    public Double getNota(){
        return nota;
    }
    
    public void setNota(double nota){
        this.nota = nota;
    }
}
