using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Intermediários_CSharp_I_Idade_em_Dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dias = int.Parse(Console.ReadLine());
            var anos = dias / 365;
            dias = dias % 365;
            var meses = dias / 30;
            dias = dias % 30;

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");

            Console.ReadKey();
        }
    }
    }
}
