using DAO.Implementations.SqlServer.Helpers;
using DAO.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Implementations.SqlServer.Mappers;

namespace DAO.Implementations.SqlServer
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




        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Mision] (FechaHora,ValorSensor1,ValorSensor2) VALUES (@FechaHora,@ValorSensor1,@ValorSensor2)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Mision] SET (idMision,FechaHora,ValorSensor1,ValorSensor2) WHERE idMision = @idMision";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Mision] WHERE idMision = @idMision";
        }

        private string SelectOneStatement
        {
            get => "SELECT idMision, idMision,FechaHora,ValorSensor1,ValorSensor2 FROM [dbo].[Misiones] WHERE idMision = @idMision";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Mision]";
        }

        private string SelectAllStatementByDate
        {
            get => "SELECT FechaHora, ValorSensor1, ValorSensor2 FROM [dbo].[Mision] WHERE CONVERT(DATE, FechaHora) BETWEEN @FechaDesde AND @FechaHasta";
        }
        #endregion


        public List<Mision> BuscarMisiones(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Mision> misiones = new List<Mision>();

            using (var reader = SqlHelper.ExecuteReader(SelectAllStatementByDate, CommandType.Text,
                 new SqlParameter[] {
                                     new SqlParameter("@FechaDesde", fechaDesde.Date),
                                     new SqlParameter("@FechaHasta", fechaHasta.Date)
               }))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);
                    
                    Mision mision = MisionMapper.Current.Fill(data);
                    misiones.Add(mision);
                }
            }

            return misiones;


        }

        public void GuardarMision(Mision mision)
        {
            SqlHelper.ExecuteNonQuery(InsertStatement, CommandType.Text,
                new SqlParameter[] { 
                                     new SqlParameter("FechaHora", mision.FechaHora),
                                     new SqlParameter("ValorSensor1", mision.ValorSensor1),
                                     new SqlParameter("ValorSensor2", mision.ValorSensor2)
                });


        }
    }
}
