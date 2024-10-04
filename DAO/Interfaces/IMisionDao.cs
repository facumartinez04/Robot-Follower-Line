using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IMisionDao
    {
        void GuardarMision(Mision mision);
        List<Mision> BuscarMisiones(DateTime fechaDesde, DateTime fechaHasta);
    }
}
