using System;

namespace classificaçaoidade
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int anonasc = 0;
            int idade;
            int atual = 2019;
            
            
            Console.Write("Qual o ano em que você nasceu? ");
            anonasc = int.Parse(Console.ReadLine());


           idade = atual - anonasc ;

             Console.Write("Você tem "+ idade + " anos; Contanto ");

           if ((idade >=0) && (idade <= 2))
           {
               Console.Write("Você é um Recém-Nascido");
           }
            else if (idade <= 11)
            {
                Console.Write("Você é uma Criança");
            }
                else if (idade <= 19)
                {
                    Console.Write("Você é um Adolescente ");
                }
                    else if (idade <= 65)
                    {
                        Console.Write("Você é um Adulto");
                    }
                        else if (idade >= 65)
                        {
                            Console.Write("Você é um Idoso");
                        }

           
            

        }
    }
}
