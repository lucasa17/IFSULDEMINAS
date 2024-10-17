programa {
  funcao inicio() {

   real km, dias

   escreva("Digite quantos dias utilizou o carro: ")
   leia(dias)

   escreva("Digite quantos km foram percorridos com o carro: ")
   leia(km)

   escreva("\nO total a pagar é de ", (dias * 60) + (km * 0.15))
  }
}
