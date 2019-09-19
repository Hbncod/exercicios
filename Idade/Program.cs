using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1,nota2,nota3,nota4,media;

            //==============Notas==================
            Console.Write("Entre a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Entre a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Entre a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Entre a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());
            // ===============Media=================
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("A média é: " + media); 

        }
    }
}
