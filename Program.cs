﻿/* Codigo feito pelo Afoope */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_de_Invers_o_de_Sequ_ncia_Num_rica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[15];

            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write($"Entre com o {i + 1}° nome : ");
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(numero);

            int t = 15;

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine($"O {t}° nome digitado era : {numero[i]}");
                t--;
            }
            Console.Read();
        }
    }
}
