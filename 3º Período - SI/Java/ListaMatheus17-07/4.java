    public static int somaVetorRecursiva(int[] vetor, int n) {
        /**
         * Retorna a soma dos elementos de um vetor de n elementos usando recursividade.
         */
        if (n <= 0) {
            return 0; // Caso base: vetor vazio ou tamanho inválido, a soma é 0
        } else {
            // Soma o último elemento (índice n-1) com a soma recursiva do restante do vetor
            return vetor[n - 1] + somaVetorRecursiva(vetor, n - 1);
        }
    }
