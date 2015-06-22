using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Odbc;

namespace Sincronizador_CadeteEnLinea.Class
{
    class Conexion
    {
        OdbcConnection DbConnection = new OdbcConnection("DSN=Odbc escuela");
        public void connect()
        {
            try
            {
                DbConnection.Open();
            }
            catch (Exception)
            {

            }
        }

        public void disconnect()
        {
            DbConnection.Close();
        }

        public OdbcDataReader execute(string comando)
        {
            try
            {
                OdbcCommand DbCommand = DbConnection.CreateCommand();
                DbCommand.CommandText = comando;
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                return DbReader;
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
