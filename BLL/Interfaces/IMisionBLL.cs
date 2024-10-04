using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    internal interface IMisionBLL
    {
        List<Mision> BuscarMisiones(DateTime fechaDesde, DateTime fechaHasta);
        void GuardarMision(Mision mision);

    }
}
