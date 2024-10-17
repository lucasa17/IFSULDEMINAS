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
