using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TypeRepository
    {
        //Dodaj Tip
        public void AddType(Type type)
        {
            string sSqlConnectionString = "Data Source = 193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO GooglePlaces_Types (Type, TypeView, Icon) VALUES  ('" + type.sType + "', '" + type.sTypeView + "', '" + type.sIcon + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    oReader.Read();
                }
            }
        }

        //Obrisi tip
        public void DeleteType(string tip)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM GooglePlaces_Types WHERE TypeView = '" + tip + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    oReader.Read();
                }
            }
        }
    }
}
