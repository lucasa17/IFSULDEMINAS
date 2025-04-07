package Aplicacao;

import Entidades.Aluno;
import Entidades.Curso;
import Entidades.Disciplina;
import java.util.List;

public class Programa {

    public static void main(String[] args) {
        Aluno a1 = new Aluno("Xebelgay", 10, 0);
        Aluno a2 = new Aluno("Yasmin",100 ,10);
        Disciplina d1 = new Disciplina("LpDoAnaoGay");
        Disciplina d2 = new Disciplina("MatDaMuieGay");
        
        Curso c1 = new Curso();
        c1.setNome("Sistema");
        c1.setPeriodo((8L));
        c1.insereAluno(a2);
        c1.insereAluno(a1);
        c1.insereDisciplina(d2);
        c1.insereDisciplina(d1);
        
        List<Disciplina> list = c1.getDisciplinas();
        
        for(Disciplina d : list){
            System.out.println(d.getNome());
        }
        
    }
    
}
