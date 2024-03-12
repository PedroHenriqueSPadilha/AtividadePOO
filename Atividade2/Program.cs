using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Program
    {
        public struct FormasGeometricas
        {
            public double Base;
            public double altura;
        }
        static void Gravar(ref FormasGeometricas FG)
        {
            Console.Write("Entre com a base do triangulo: ");
            FG.Base = double.Parse(Console.ReadLine());
            Console.Write("Entre com a altura do triangulo: ");
            FG.altura = double.Parse(Console.ReadLine());
        }
        static double AreaTriangulo(ref FormasGeometricas FG)
        {
            double result = 0;
            result = (FG.Base * FG.altura) / 2;
            return result;
        }

        static void Mostrar(ref FormasGeometricas f)
        {
            Console.WriteLine($"O total: {AreaTriangulo(ref f)}");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            FormasGeometricas f1 = new FormasGeometricas();
            Gravar (ref f1);
            Mostrar(ref f1);
            Console.ReadKey();
        }
    }
}
