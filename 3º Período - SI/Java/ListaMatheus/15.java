public int posicaoElemento(int valor) {
    No atual = inicio;
    int pos = 0;
    while (atual != null) {
        if (atual.dado == valor) {
            return pos;
        }
        atual = atual.proximo;
        pos++;
    }
    return -1; // não encontrado
}
