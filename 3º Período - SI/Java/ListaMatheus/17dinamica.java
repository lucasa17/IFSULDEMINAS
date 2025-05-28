public int quantidade() {
    int cont = 0;
    No atual = inicio;
    while (atual != null) {
        cont++;
        atual = atual.proximo;
    }
    return cont;
}
