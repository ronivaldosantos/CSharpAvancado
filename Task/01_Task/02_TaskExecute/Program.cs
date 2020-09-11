﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TaskExecute
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formas para acionamento de Tasks.
            Task.Run(() => Metodo01());
            Task.Run(() => Metodo01());

            Task.Factory.StartNew(Metodo01);

            Console.ReadKey();
        }

        static void Metodo01() 
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Valor: " + i + " Id Task: " + Task.CurrentId);
            }
        }
    }
}
