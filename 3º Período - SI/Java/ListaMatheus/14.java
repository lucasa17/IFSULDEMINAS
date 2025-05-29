public boolean contemElemento(int elemento) {
    if (inicio == fim){
      return false;
    }  
    int i = inicio;
    while (i != fim) {
        if (dados[i] == elemento) {
            return true;
        }
        i++;
        if (i == tamanho) {
            i = 0;
        }
    }
    return false;
}
