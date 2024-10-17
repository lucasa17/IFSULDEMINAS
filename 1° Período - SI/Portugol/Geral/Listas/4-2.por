programa {
funcao inicio() {
inteiro i = 0, j, x, aux
para(inteiro x = 0; x < 3; x++){
escreva("Digite as idades: ")
leia(aux)
se(i == 0){
i = aux
j = aux
}
se(i > aux){
i = aux
}
se(j < aux){
j = aux
}
}
escreva("Maior = ",j)
escreva("\nMenor = ",i)
}
}
