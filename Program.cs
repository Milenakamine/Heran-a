using System;

namespace Heran_a
{
    class Program
    {
        static void Main(string[] args)
        {
           CPF cpf = new CPF();
           cpf.nome= "Milena";
           System.Console.WriteLine (cpf.saudar());

           cpf.cpf = "000.000.000-00";
           System.Console.WriteLine(cpf.ValidarCPF());
        }
    }
}
