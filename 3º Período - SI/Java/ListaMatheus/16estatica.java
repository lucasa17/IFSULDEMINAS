public int ultimoElemento() {
    if (inicio == fim) {
        System.out.println("Fila vazia");
    return -1;
    }
    int pos;
    if (fim == 0) {
        pos = tamanho - 1;
    } else {
        pos = fim - 1;
    }
    return dados[pos];
}
