using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario() {Nome="José",Email="jose@gmail.com"});
            lista.Add(new Usuario() { Nome = "Maria", Email = "maria@hotmail.com" });
            lista.Add(new Usuario() { Nome = "João", Email = "joao@ig.com" });
            lista.Add(new Usuario() { Nome = "Felipe", Email = "felipe@gmail.com" });
            lista.Add(new Usuario() { Nome = "Ronivaldo", Email = "ronivaldo@gmail.com" });

            var listaFiltrada = lista.Where(a => a.Email.Contains("@gmail")).OrderBy(a=>a.Nome).Select(a => a);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item.Nome + " - " + item.Email);
            }

            Console.ReadKey();

        }
    }
}
