using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _02_Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "jose",Email="jose",Senha="123456"} ;
            
            ValidationContext contexto = new ValidationContext(usuario);
            List<ValidationResult> resultados = new List<ValidationResult>();

            if (!Validator.TryValidateObject(usuario, contexto, resultados,true)) 
            {
                //Mensagens de consistência
                foreach (var erro in resultados)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
                Console.ReadKey();
            }

        }
    }
}
