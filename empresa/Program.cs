using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salario,valor;
            decimal porcento;


            Console.Write("me diga seu salário: ");
            salario = decimal.Parse(Console.ReadLine());

            porcento = 1.3M;

            if(salario >= 500){

                Console.Write("Sinto muito, infelizmente você não ganhou um aumento");
            }
            else{
                valor = salario * porcento;
                Console.Write($"Parabens, você ganhou um aumento. Agora seu salário agora é: {valor}");
            }
        }
    }
}
