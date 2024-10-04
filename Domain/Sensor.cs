using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sensor
    {
        public bool Valor { get; set; }

        public Sensor(bool valorInicial)
        {
            Valor = valorInicial;
        }
    }
}
