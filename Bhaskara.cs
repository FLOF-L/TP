using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EX12
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, delta, x1, x2;
            Console.Clear();
            Console.Write("Coeficiente A : ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Coeficiente B : ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Coeficiente C : ");
            c = float.Parse(Console.ReadLine());
            delta = (float)Math.Pow(b, 2) - (4 * a * c);
            if (a == 0)
            {
                Console.WriteLine("Não forma equação do 2º grau");
            }
            else
            {
                if (delta < 0)
                {
                    Console.WriteLine("Não existem raízes reais");
                }
                else
                {
                    x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1 = {0:f}", x1);
                    Console.WriteLine("x2 = {0:f}", x2);
                }

            }
        }
    }
}
