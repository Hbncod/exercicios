using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int [6];
            int par = 0;
            int impar = 0;

            for (int indice = 0; indice <= 5;indice ++){
            
                Console.WriteLine($"Escolha seu {indice + 1}° Número");
                n[indice] = int.Parse(Console.ReadLine());
            }
            for(int indice = 0; indice <= 5;indice ++){

                if (n[indice] % 2 == 0)
                {
                    par = par + 1;
                    
                }      
                else{
                    impar = impar + 1;
                }
            }
                Console.WriteLine($"Você possui {par} números pares");
                Console.WriteLine($"Você possui {impar} números impares");
                

        }
    }
}
