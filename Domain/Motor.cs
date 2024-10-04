using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Motor
    {
        public int Potencia { get; set; }
        public string Direccion { get; set; }

        public Motor(int potencia, string direccion)
        {
            Potencia = potencia;
            Direccion = direccion;
        }

    }
}
