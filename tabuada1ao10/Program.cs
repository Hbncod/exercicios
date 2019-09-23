using System;

namespace tabuada1ao10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte mult = 1;
            byte num = 1;

            for(mult = 1; mult <= 10; mult ++){
                for (num = 1; num <=10; num ++ )
                Console.WriteLine($"{num} * {mult} = {num*mult}\t");
            }   
        }
    }
}
