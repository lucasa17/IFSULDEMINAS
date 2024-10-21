using System;

class HelloWorld {
    
  static void Main() {
      
    Console.WriteLine("Matriz");
    
    int[,] matriz = new int[3,3];
    
    for(int i = 0; i < 3; i++){
        
        for(int j = 0; j < 3; j++){
            
            matriz[i,j] = int.Parse(Console.ReadLine());
                    
        }
        
    }
    
    for(int i = 0; i < 3; i++){
        
        for(int j = 0; j < 3; j++){
            
            Console.Write("["+i+"]["+j+"] = "+matriz[i,j]+" |  ");

        }
        
    }
    
  }
}
