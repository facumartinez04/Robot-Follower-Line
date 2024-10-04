using DAO.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer.Mappers
{
    public sealed class MisionMapper : IObjectMapper<Mision>
    {


      
        #region singleton
            private readonly static MisionMapper _instance = new MisionMapper();

            public static MisionMapper Current
            {
                get
                {
                    return _instance;
                }
            }

            private MisionMapper()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
       


        public Mision Fill(object[] values)
        {
            Mision mision = new Mision();
            mision.FechaHora = (DateTime)values[0];
            mision.ValorSensor1 = (bool)values[1];
            mision.ValorSensor2 = (bool)values[2];
            return mision;
        }
    }
}
