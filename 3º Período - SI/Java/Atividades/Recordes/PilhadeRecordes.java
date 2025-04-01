import java.util.Arrays;

public class PilhaDeRecordes {
    private Recorde[] pilha;
    private int tamanho;
    private int capacidade;

    public PilhaDeRecordes(int capacidade) {
        this.capacidade = capacidade;
        this.pilha = new Recorde[capacidade];
        this.tamanho = 0;
    }

    public void empilhar(Recorde recorde) {
        if (tamanho == 0 || recorde.getTempo() < pilha[tamanho - 1].getTempo()) {
            if (tamanho == capacidade) {
                redimensionar();
            }
            pilha[tamanho++] = recorde;
            System.out.println("Recorde adicionado: " + recorde);
        } else {
            System.out.println("O tempo do novo recorde deve ser menor que o recorde atual.");
        }
    }

    public Recorde topo() {
        if (tamanho == 0) {
            return null;
        }
        return pilha[tamanho - 1];
    }

    public Recorde desempilhar() {
        if (tamanho == 0) {
            return null;
        }
        Recorde recorde = pilha[--tamanho];
        pilha[tamanho] = null; // Para evitar vazamento de memória
        return recorde;
    }

    public void listarRecordes() {
        if (tamanho == 0) {
            System.out.println("Nenhum recorde armazenado.");
            return;
        }
        for (int i = 0; i < tamanho; i++) {
            System.out.println(pilha[i]);
        }
    }

    private void redimensionar() {
        capacidade *= 2;
        pilha = Arrays.copyOf(pilha, capacidade);
        System.out.println("Pilha redimensionada para capacidade: " + capacidade);
    }
}
