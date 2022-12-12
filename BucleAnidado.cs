using System;

namespace MyProgram
{
  class Bucle
  {
    static void Main(string[] args)
    {
      // Bucle exterior que se complementa con un bucle interior 
      
      for (int i = 1; i <= 2; ++i) 
      {
        Console.WriteLine("Outer: " + i);  
        
        // Inner loop
        for (int j = 1; j <= 3; j++) 
        {
          Console.WriteLine(" Inner: " + j);  
        }
      }    
    }
  }
}
