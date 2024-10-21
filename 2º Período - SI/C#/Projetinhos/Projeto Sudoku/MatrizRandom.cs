using System;

class Matriz {
    
  static void Main() {
      
    Console.WriteLine("Matriz");
    
    int[,] matriz = new int[3,3];
    
    
    Random random = new Random();

    for(int i = 0; i < 3; i++){
        
        for(int j = 0; j < 3; j++){
            
            //Console.Write("["+i+"]["+j+"] = ");
            matriz[i,j] = random.Next(1,10);
                    
        }
        
    }
    
    int cont = 0;
    
    for(int i = 0; i < 3; i++){
        
        for(int j = 0; j < 3; j++){
            
            if(cont % 3 == 0){
                
                Console.Write("\n");
                
            }
    
            Console.Write(matriz[i,j]+"  ");
            
            cont++;
        }
        
    }
    
  }
}
