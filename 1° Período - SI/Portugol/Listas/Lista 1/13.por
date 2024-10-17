programa {
  funcao inicio() {

  cadeia nome
  real salario, vendas
  

  escreva("Digite o nome do vendedor: ")
  leia(nome)

  escreva("Digite o valor do sálario fixo do vendedor: ")
  leia(salario)

  escreva("Digite o total das vendas desse vendedor no mês: ")
  leia(vendas)

  escreva("O vendedor ", nome, "que tem seu salário fixo de R$", salario, " receberá ao fim do mês R$", salario + (vendas*1.15) , " com o resultado de suas vendas.")


  }
}
