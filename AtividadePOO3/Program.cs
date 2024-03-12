using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO3
{
    internal class Program
    {
        public struct Funcionario
        {
            public string nome;
            public double salario;

        }

        static void Gravar(ref Funcionario F)
        {
            Console.Write("Digite o seu nome:");
            F.nome = Console.ReadLine();
            Console.Write("Digite o seu salário:");
            F.salario = double.Parse(Console.ReadLine());
        }

        static void Mostrar(Funcionario F)
        {
            Console.WriteLine($"O funcionario: {F.nome}, recebe:{F.salario.ToString("0,00")}");
        }


        static void Main(string[] args)
        {
            int op = 0;
            Funcionario a1;
            a1.nome = "";
            a1.salario = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1-Gravar Nome e Salário");
                Console.WriteLine("2-Mostrar Salário do Funcionario");
                Console.WriteLine("3-Sair");
                Console.Write("Entre com uma opção:");
                op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        Gravar(ref a1);
                        break;

                    case 2:
                        Mostrar(a1);
                        Console.ReadKey();
                        break;

                }
            } while (op != 3);
        }
    }
}
