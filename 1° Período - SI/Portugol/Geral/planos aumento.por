programa {
  funcao inicio() {
    
    inteiro opcao
    real salario

  escreva("Digite seu s�lario atual: ")
  leia(salario)

    escreva("\nPlanos:")
    escreva("\nPlano | Aumento")
    escreva("\n  1   |   10%  ")
    escreva("\n  2   |   20%  ")
    escreva("\n  3   |   30%  \n")

  escreva("\nEscolha seu plano: ")  
  leia(opcao)

  escolha(opcao){

    caso 1:
      escreva("\nSeu s�lario agora ser� de R$", salario*1.1)
    pare

    caso 2:
      escreva("\nSeu s�lario agora ser� de R$", salario*1.2)
    pare

    caso 3:
      escreva("\nSeu s�lario agora ser� de R$", salario*1.3)
    pare

    caso contrario:
      escreva("\nValor inv�lido.")
  }
  


  }
}
