using DAO.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.Memory
{
    public sealed class MisionDao : IMisionDao
    {


         #region singleton
            private readonly static MisionDao _instance = new MisionDao();

            public static MisionDao Current
            {
                get
                {
                    return _instance;
                }
            }

            private MisionDao()
            {
                //Implent here the initialization of your singleton
            }
        #endregion

        private string filePath = ConfigurationManager.AppSettings["MisionPath"];


        public List<Mision> BuscarMisiones(DateTime fechaDesde, DateTime fechaHasta)
        { 
            var misiones = CargarMisiones();
            
            return misiones.FindAll(m => m.FechaHora.Date >= fechaDesde.Date && m.FechaHora.Date <= fechaHasta.Date);


        }

        public void GuardarMision(Mision mision)
        {
            List<Mision> misiones = CargarMisiones();
            misiones.Add(mision);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, misiones);
            }
        }


        public List<Mision> CargarMisiones()
        {
            if (!File.Exists(filePath))
            {
                return new List<Mision>();
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Mision>)formatter.Deserialize(fs);
            }
        }
    }
}
