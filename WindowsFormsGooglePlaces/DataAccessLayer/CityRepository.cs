using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CityRepository
    {
        //ako ne radi, onda samo getCities funkciju 
        public void AddCity(string name, string latitude, string longitude)
        {
            string sSqlConnectionString = "Data Source = 193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {

                oCommand.CommandText = "INSERT INTO GooglePlaces_Cities (Name, Latitude, Longitude) VALUES  ('" + name + "', " + latitude + ", " + longitude + ")";
                Console.WriteLine(oCommand.CommandText);
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    oReader.Read();
                }
            }
        }

    }
}
