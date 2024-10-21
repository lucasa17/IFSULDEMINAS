using System;

class HelloWorld {
    
    
    static int[,] makeMatriz() {
        
    int[,] matriz = new int[3,3];
            
            
            Random random = new Random();
            
            for(int i = 0; i < 3; i++){
                
                for(int j = 0; j < 3; j++){
                    
                    voltar:
                    //Console.Write("["+i+"]["+j+"] = ");
                    matriz[i,j] = random.Next(1,10);
                            
                    if(i == 0 && j == 1){
                        
                        if(matriz[i,j-1] == matriz[i,j]){
                            
                            goto voltar;
                        }
                        
                    }
                    else if(i == 0 && j == 2){
                        
                        if(matriz[i,j-1] == matriz[i,j] || matriz[i,j-2] == matriz[i,j]){
                            
                            goto voltar;
                        }
                        
                    }
                    
                    
                    if(i == 1 && j == 0){
                        
                        if(matriz[i-1,j] == matriz[i,j] || matriz[i-1,j+1] == matriz[i,j] || matriz[i-1,j+2] == matriz[i,j]){
                            
                            goto voltar;
                        }
                        
                    }
                    else if(i == 1 && j == 1){
                        
                        if(matriz[i-1,j-1] == matriz[i,j] || matriz[i-1,j] == matriz[i,j] || matriz[i-1,j+1] == matriz[i,j] || matriz[i,j-1] == matriz[i,j]){
                            
                            goto voltar;
                        }
                    }
                    else if(i == 1 && j == 2){
                        
                        if(matriz[i-1,j-2] == matriz[i,j] || matriz[i-1,j-1] == matriz[i,j] || matriz[i-1,j] == matriz[i,j] || matriz[i,j-1] == matriz[i,j] || matriz[i,j-2] == matriz[i,j]){
                            
                            goto voltar;
                        }
                    }
                    
                    
                    if(i == 2 && j == 0){
                        
                        if(matriz[i-1,j] == matriz[i,j] || matriz[i-1,j+1] == matriz[i,j] || matriz[i-1,j+2] == matriz[i,j] || matriz[i-2,j] == matriz[i,j] || matriz[i-2,j+1] == matriz[i,j] || matriz[i-2,j+2] == matriz[i,j]){
                            
                            goto voltar;
                        }
                        
                    }
                    else if(i == 2 && j == 1){
                        
                        if(matriz[i,j-1] == matriz[i,j] || matriz[i-1,j+1] == matriz[i,j] || matriz[i-1,j] == matriz[i,j] || matriz[i-1,j-1] == matriz[i,j] || matriz[i-2,j+1] == matriz[i,j] || matriz[i-2,j] == matriz[i,j] || matriz[i-2,j-1] == matriz[i,j]){
                            
                            goto voltar;
        
                        }
                    }
                    else if(i == 2 && j == 2){
                        
                        if(matriz[i,j-2] == matriz[i,j] || matriz[i,j-1] == matriz[i,j] || matriz[i-1,j] == matriz[i,j] || matriz[i-1,j-1] == matriz[i,j] || matriz[i-1,j-2] == matriz[i,j] || matriz[i-2,j] == matriz[i,j] || matriz[i-2,j-1] == matriz[i,j] || matriz[i-2,j-2] == matriz[i,j]){
                            
                            goto voltar;
        
                        }
                    }
                   
                }
                
            }
            
        return matriz;
        
    }
    
    
    static void showMatriz(int[,] matriz){
        
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
    
  static void Main() {
      
    Console.WriteLine("Matriz");
    Console.Write("--------------");

    int a = 0;
    
    while(a != 3){
        
            int[,] matriz = makeMatriz();
                        
            showMatriz(matriz);
            
            Console.Write("\n--------------");
            
            a++;
    }
    
  }
}
