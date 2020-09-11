using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Reflection.Modelo
{
    class Carro : ICloneable
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public object Clone()
        {
            return new Carro() { Marca = this.Marca, Modelo = this.Modelo };
        }
    }
}
