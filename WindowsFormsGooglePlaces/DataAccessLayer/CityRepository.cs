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
        //DOHVATI GRADOVE IZ BP 
        public List<City> GetCities()
        {
            var cities = new List<City>();
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = oConnection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM GooglePlaces_Cities";
                oConnection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cities.Add(new City()
                        {
                            Name = (string)reader["Name"],
                            Latitude = (decimal)reader["Latitude"],
                            Longitude = (decimal)reader["Longitude"]
                        });
                    }
                }
            }
            return cities;
        }

    }
}
