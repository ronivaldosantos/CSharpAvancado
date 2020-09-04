using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de livros
            List<Livro> listaLivro = new List<Livro>();
            listaLivro.Add(new Livro() { Id = 1, AutorId = 2, Titulo = "Amor amado" });
            listaLivro.Add(new Livro() { Id = 2, AutorId = 2, Titulo = "Bem amado" });
            listaLivro.Add(new Livro() { Id = 3, AutorId = 3, Titulo = "Um espião em Washigton" });
            listaLivro.Add(new Livro() { Id = 4, AutorId = 1, Titulo = "A vida na terra" });

            //Lista de autores
            List<Autor> listaAutor = new List<Autor>();
            listaAutor.Add(new Autor() { Id = 1, Nome = "Leonardo" });
            listaAutor.Add(new Autor() { Id = 2, Nome = "Maria Maria"});
            listaAutor.Add(new Autor() { Id = 3, Nome = "Joseph" });

            // ******* Utilizando LINQ e LAMBDA para junção de objetos através de JOIN. *******
                                                                                                                      //** Tipo anônimus **  
            var listaJoin = from livros in listaLivro join autor in listaAutor on livros.AutorId equals autor.Id select new { livros,autor};

            foreach (var item in listaJoin)
            {
                Console.WriteLine("Livro: " + item.livros.Titulo + " - Autor: " + item.autor.Nome);
            }
                
            Console.ReadKey();
        }
    }
}
