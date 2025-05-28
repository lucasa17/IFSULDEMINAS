public boolean estaCrescente() {
    if (inicio == null || inicio.proximo == null){
    return true;
    }
    No atual = inicio;
    while (atual.proximo != null) {
        if (atual.dado > atual.proximo.dado) {
            return false;
        }
        atual = atual.proximo;
    }
    return true;
}
