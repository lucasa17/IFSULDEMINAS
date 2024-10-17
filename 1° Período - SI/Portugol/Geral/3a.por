
programa
{
    funcao inicio()
    {
        inteiro numero

        faca
        {
            escreva("Digite um número inteiro (0 para sair): ")
            leia(numero)

            se (numero != 0)
            {
                escreva("Representação binária de ", numero, " é: ", decimalParaBinario(numero), "\n")
            }
        }
        enquanto (numero != 0)
    }

    funcao cadeia decimalParaBinario(inteiro numero)
    {
        cadeia binario = ""
        inteiro quociente = numero

        enquanto (quociente > 0)
        {
            binario = (quociente % 2) + binario
            quociente = quociente / 2
        }

        se (binario == "")
        {
            binario = "0"
        }

        retorne binario
    }
}
