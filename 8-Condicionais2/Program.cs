﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 ");

            int idadeJoao = 18;
            bool acompanhado = false;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
            Console.ReadLine();

        }
    }
}
