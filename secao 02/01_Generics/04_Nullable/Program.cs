using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Não aceita valor nulo por tratar-se de um struct
           //ERRO: int valor = null;

            // Alternativa quando precisar gravar null no BD.
            Nullable<int> valor2 = null;
            int? valor3 = null;

        }
    }
}
