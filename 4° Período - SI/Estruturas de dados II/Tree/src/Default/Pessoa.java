package Default;

import java.util.Objects;

public class Pessoa implements Comparable<Pessoa> {
    private String nome;
    private Integer matricula;
    public String getNome() {
        return nome;
    }
    public void setNome(String nome) {
        this.nome = nome;
    }
    public Integer getMatricula() {
        return matricula;
    }
    public void setMatricula(int matricula) {
        this.matricula = matricula;
    }

    @Override
    public int compareTo(Pessoa outraPessoa){
        return this.matricula.compareTo(outraPessoa.getMatricula());
    }

    @Override
    public String toString(){
        return "|" +this.matricula+ "-" + this.nome + "|";
    }
	@Override
	public int hashCode() {
		return Objects.hash(matricula);
	}
	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Pessoa other = (Pessoa) obj;
		return Objects.equals(matricula, other.matricula);
	}
    



}
