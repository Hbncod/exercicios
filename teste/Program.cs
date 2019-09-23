using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma = "";
            double baseh;
            double altura;
            double baseh2;
         

                while (forma != "fim")
                {
                    Console.WriteLine("Você quer calcular a área de qual forma geométrica?");
                    forma = Console.ReadLine();

                
                    switch(forma){
                            

                    // =====================QUADRADO==========================
                        case "quadrado":
                        
                        Console.Write("qual sua base? ");
                        baseh = double.Parse(Console.ReadLine());

                        Console.Write("Qual sua altura? ");
                        altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("a área é " + baseh * altura);
                        break;

                    // ================TRIANGULO======================
                        case "triângulo":
                        
                        Console.Write("qual sua base? ");
                        baseh = double.Parse(Console.ReadLine());

                        Console.Write("Qual sua altura? ");
                        altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("a área é " + baseh * altura / 2);
                        break;

                    // =====================CÍRCULO============================
                        case "circulo":
                        
                        Console.Write("qual seu raio? ");
                        baseh = double.Parse(Console.ReadLine());

                        Console.WriteLine("a área é " + (baseh*baseh) * 3,14);
                        break;

                    // ================TRAPÉZIO======================
                        case "trapezio":
                        
                        Console.Write("qual sua base? ");
                        baseh = double.Parse(Console.ReadLine());

                        Console.Write("qual sua base superior? ");
                        baseh2 = double.Parse(Console.ReadLine());

                        Console.Write("Qual sua altura? ");
                        altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("a área é " + ((baseh + baseh2) * altura) / 2 );
                        break;

                    // ================RETÂNGULO=====================
                        case "retangulo":
                        
                        Console.Write("qual sua base? ");
                        baseh = double.Parse(Console.ReadLine());

                        Console.Write("Qual sua altura? ");
                        altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("a área é " + baseh * altura);
                        break;
                    
                    // =====================losango==========================
                        case "losango":
                        
                        Console.Write("qual sua diagonal maior? ");
                        baseh = double.Parse(Console.ReadLine());

                        Console.Write("Qual sua diagonal menor? ");
                        altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("a área é " + baseh * altura / 2);
                        break;

                    default:
                        Console.WriteLine("Desculpe,não entendi; lembre-se, escreva o nome de sua forma geométrica sem assentos");
                    break;
                    }
                }
        }
    }
}
