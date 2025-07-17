    public static int somaVetorRecursiva(int[] vetor, int n) {
        if (n <= 0) {
            return 0; 
        } else {
            return vetor[n - 1] + somaVetorRecursiva(vetor, n - 1);
        }
    }
