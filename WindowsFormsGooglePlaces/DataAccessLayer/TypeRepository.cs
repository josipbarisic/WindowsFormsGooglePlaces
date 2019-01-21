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

        //Dohvati sve tipove
        public List<Type> GetAllTypes()
        {
            var types = new List<Type>();
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = oConnection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM GooglePlaces_Types";
                oConnection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        types.Add(new Type()
                        {
                            sType = (string)reader["Type"],
                            sTypeView = (string)reader["TypeView"],
                            sIcon = (string)reader["Icon"]
                        });
                    }
                }
            }
            return types;
        }

        //DOHVATI ODABRANI TIP
        public string GetSelectedType(string type)
        {
            string sTip = "Tip nije pronađen";
            var oTypes = GetAllTypes();
            foreach(var tip in oTypes)
            {
                if(type == tip.sTypeView)
                {
                    sTip = tip.sType;
                }
            }
            return sTip;
        }

        //Convert sType u sTypeView
        public string GetTypeView(string type)
        {
            string sTip = "Tip nije pronađen";
            var oTypes = GetAllTypes();
            foreach (var tip in oTypes)
            {
                if (type == tip.sType)
                {
                    sTip = tip.sTypeView;
                }
            }
            return sTip;
        }
    }
}
