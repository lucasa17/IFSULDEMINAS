/*Uma brincadeira que crianças adoram é se comunicar na língua do P,
acrescentando pê antes de cada sílaba, como uma forma de código para dificultar que outras
pessoas entendam a conversa (pê-va pê-mos pê-no pê-ci pê-ne pê-ma?). Jacy e Kátia adaptaram
a língua do P para mensagens eletrônicas, acrescentando a letra P minúscula 'p' antes de cada
letra das palavras de uma mensagem.*/

using System;

class Exercicio11{
    
 
    static void textoDecodificado(string texto){
        
        string textoFinal = "";
    
        int y = 0, z = 0;
        
    
        for(int x = 0; x < texto.Length; x++){
        
            if(texto[x] != 'p' || (texto[x] == 'p' && texto[y+1] == 'p' && texto[z+2] == 'p')){
                textoFinal += texto[x];
                
            }
            
        }
        
        Console.Write(textoFinal); 
    }
    
    static void Main() {
        
    
    
    
    Console.Write("Digite seu texto: ");
    string texto = Console.ReadLine();
    
    textoDecodificado(texto);
    

  }
}
