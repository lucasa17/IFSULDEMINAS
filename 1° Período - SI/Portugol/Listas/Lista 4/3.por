programa {
funcao inicio() {
inteiro x, a, aux = 0
para(inteiro x = 0; x < 5; x++){
escreva("Digite um valor: ")
leia(a)
se(aux == 0){
aux = a
}
se(aux < a){
aux = a
}
}
escreva("Maior valor é ", aux)
}
}
