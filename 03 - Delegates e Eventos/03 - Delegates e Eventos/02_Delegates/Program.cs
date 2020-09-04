﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Delegates.Lib;

namespace _02_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tela - Cadastro de usuário: Thumb (foto perfil)
            Foto foto = new Foto() { Nome = "perfil.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processar(foto);
            
            //Tela - Cadastro de produtos: Colorir + TamanhoMedio
            Foto foto2 = new Foto() { Nome = "produto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().RedimensionarTamMedio;
            FotoProcessador.Processar(foto2);

            //Tela - Cadastro de albuns de usuário - Retro: Preto e Branco
            Foto foto3 = new Foto() { Nome = "album.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processar(foto3);                                 

            Console.ReadKey();
        }

        
    }
}
