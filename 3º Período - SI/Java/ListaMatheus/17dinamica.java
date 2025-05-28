public int quantidade() {
    int count = 0;
    No atual = inicio;
    while (atual != null) {
        count++;
        atual = atual.proximo;
    }
    return count;
}
