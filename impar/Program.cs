using System;

namespace impar
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 1;
        
                while (num != 0) {

                Console.WriteLine("escolha um número");
                num = double.Parse(Console.ReadLine());

                if (num % 2 == 0){
                    Console.WriteLine("Seu número é PAR");
                    }
                else{
                    Console.WriteLine("Seu número é IMPAR");  
                    }
            }
        }
    }
}
