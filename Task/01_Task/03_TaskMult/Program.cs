using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _03_TaskMult
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamando uma lista de tarefas.
            List<Task> lista = new List<Task>();
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));

            Task.WaitAll(lista.ToArray());


            //Obtem lista de sites para download
            string[] enderecos = new string[] {"Http://www.google.com.br", "Http://www.microsoft.com.br", "Http://www.gi.com.br" };

            var listaEnd = from end in enderecos select DownloadPagina(end);
            Task.WaitAll(listaEnd.ToArray());

            Console.WriteLine("Programa finalizado!!!");
            Console.ReadKey();
        }

        static void Metodo01()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Valor: " + i + " Id Task: " + Task.CurrentId);
            }
        }

        static async Task DownloadPagina(string end)
        {
            WebClient web = new WebClient();
            string html = await web.DownloadStringTaskAsync(end);
            Console.WriteLine("Download realizado para a página: " + end);
        }
    }
}
