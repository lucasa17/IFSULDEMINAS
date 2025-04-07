package Entidades;

import java.util.ArrayList;
import java.util.List;
import java.util.List;

public class Curso {
    
    private String nome;
    private long periodo;
    private List<Aluno> alunos = new ArrayList<>();
    private List<Disciplina> disciplinas = new ArrayList<>();

    public Curso(){
        
    }

    public Curso(String nome, long periodo, List<Aluno> alunos, List<Disciplina> disicplinas) {
        this.nome = nome;
        this.periodo = periodo;
        this.alunos = alunos;
        this.disciplinas = disciplinas;
    }
    
    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public long getPeriodo() {
        return periodo;
    }

    public void setPeriodo(long periodo) {
        this.periodo = periodo;
    }
    
    public boolean insereAluno(Aluno aluno){
        for(Aluno a : alunos){
            if(aluno.getNome().equals(a.getNome())){
                return false;
            }
        }
        alunos.add(aluno);
        return true;
        }

        public List<Aluno> getAlunos(){
            return this.alunos;
    }
    
    public boolean insereDisciplina(Disciplina disciplina){
        for(Disciplina d : this.disciplinas){
            if(disciplina.getNome().equals(d.getNome())){
                return false;
            }
        }
        disciplinas.add(disciplina);
        return true;
        }
    
    public List<Disciplina> getDisciplinas(){
        return this.disciplinas;
    }
}
