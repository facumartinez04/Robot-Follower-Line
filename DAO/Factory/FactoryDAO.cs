// FactoryDao.cs (Factory)
using DAO.Interfaces;
using System;
using System.Configuration;

namespace Dao.Factory
{
    public static class FactoryDao
    {
        private static int backendType;

        static FactoryDao()
        {
            backendType = int.Parse(ConfigurationManager.AppSettings["BackendType"]);
        }

        public static IMisionDao MisionDao
        {
            get
            {
                switch ((BackendType)backendType)
                {
                    case BackendType.Memory:
                        return DAO.Implementations.Memory.MisionDao.Current;
                    case BackendType.SqlServer:
                        return DAO.Implementations.SqlServer.MisionDao.Current;
                    case BackendType.Sqlite:
                        // Implementación para SQLite
                        throw new NotImplementedException();
                    case BackendType.Oracle:
                        // Implementación para Oracle
                        throw new NotImplementedException();
                    default:
                        throw new ArgumentException("Tipo de persistencia no soportado.");
                }
            }
        }
    }

    internal enum BackendType
    {
        Memory = 1,
        SqlServer = 2,
        Sqlite = 3,
        Oracle = 4
    }
}