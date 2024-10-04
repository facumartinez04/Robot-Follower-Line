using BLL.Interfaces;
using Dao.Factory;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public sealed class MisionBLL : IMisionBLL
    {


       
            #region singleton
            private readonly static MisionBLL _instance = new MisionBLL();

            public static MisionBLL Current
            {
                get
                {
                    return _instance;
                }
            }

            private MisionBLL()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
       

        public List<Mision> BuscarMisiones(DateTime fechaDesde, DateTime fechaHasta)
        {

            return FactoryDao.MisionDao.BuscarMisiones(fechaDesde,fechaHasta);
        }

        public void GuardarMision(Mision mision)
        {
            
            FactoryDao.MisionDao.GuardarMision(mision);
        }
    }
}
