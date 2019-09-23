using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string senha;
            string senhaadm;
            string usuarioadm;

            Console.WriteLine("Digite seu Usuário");
            usuario = Console.ReadLine();

            Console.WriteLine("Digite Sua Senha");
            senha = Console.ReadLine();

            usuarioadm = "admin";
            senhaadm = "admin";

            if ((usuario == usuarioadm) && (senha == senhaadm))
            {
                Console.WriteLine("Olá Administrador");
            }
            else
            {
                Console.WriteLine("Olá Usuário");
            }
        }
    }
}
