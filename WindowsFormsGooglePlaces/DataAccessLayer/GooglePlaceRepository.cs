using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DataAccessLayer
{
    public class GooglePlaceRepository
    {

        public GooglePlaceRepository()
        {
            //
        }

        public List<GooglePlace> _googlePlaces = new List<GooglePlace>();

        //PRETRAZI MJESTA
        public List<GooglePlace> SearchPlace(string type, double lat, double lng)
        {
            string json = CallRestMethod(GenerateUrl(type,lat,lng));
            JObject jsonObject = JObject.Parse(json);
            JToken results = jsonObject.SelectToken("results");

            foreach (JObject place in results)
            {
                _googlePlaces.Add(
                    new GooglePlace
                    {
                        Id = (string)place.GetValue("id"),
                        Name = (string)place.GetValue("name"),
                        Lat = (decimal)place.SelectToken("geometry.location.lat"),
                        Lng = (decimal)place.SelectToken("geometry.location.lng"),
                        Type = type
                    });
            }

            return _googlePlaces;
        }
        //Metoda za izradu url-a
        public string GenerateUrl(string type, double lat, double lng)
        {
            var url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location="+ lat + ","+ lng +"&radius=10000&type="+ type +"&key=AIzaSyDqRf_8ncNpVfYKi4VsHlsC7BzVjCC716s";
            return url;
        }       

        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        //DODAJ MJESTO
        public void AddPlace(GooglePlace place)
        {
           
            var repoTypes = new TypeRepository();

            string sSqlConnectionString = "Data Source = 193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {

                oCommand.CommandText = "INSERT INTO GooglePlaces_Places (Id, Name, Lat, Lng, Type, City) VALUES  ('" + place.Id + "', '" + place.Name + "', '" + place.Lat + "', '" + place.Lng + "', '" + repoTypes.GetTypeView(place.Type) + "','" + place.City + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    oReader.Read();
                }
            }
                
        }

        //OBRISI MJESTO
        public void DeletePlace(string id)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM GooglePlaces_Places WHERE Id = '" + id + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    oReader.Read();
                }
            }
        }

        //DOHVATI SVA MJESTA IZ BP
        public List<GooglePlace> GetPlaces()
        {
            var places = new List<GooglePlace>();
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = oConnection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM GooglePlaces_Places";
                oConnection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        places.Add(new GooglePlace()
                        {
                            Id = (string)reader["Id"],
                            Name = (string)reader["Name"],
                            Lat = (decimal)reader["Lat"],
                            Lng = (decimal)reader["Lng"],
                            Type = (string)reader["Type"],
                            City = (string)reader["City"]
                        });
                    }
                }
            }
            return places;
        }
        
        //DOHVATI MJESTA PO GRADU I TIPU
        public List<GooglePlace> GetCityPlaces(string grad, string tip)
        {
            var repoCity = new CityRepository();
            var getCities = repoCity.GetCities();

            var repoTypes = new TypeRepository();
            var placeType = repoTypes.GetSelectedType(tip);

            List<GooglePlace> oPlaces = new List<GooglePlace>();

            foreach (var city in getCities)
            {
                if (String.Equals(grad, city.Name, StringComparison.OrdinalIgnoreCase))
                {
                    var getSearchResults = SearchPlace(placeType, (double)city.Latitude, (double)city.Longitude);
                    //DODAVANJE MJESTA
                    foreach (var result in getSearchResults)
                    {
                        oPlaces.Add(new GooglePlace()
                        {
                            Id = result.Id,
                            Name = (result.Name).Replace("'", "`"),
                            Lat = result.Lat,
                            Lng = result.Lng,
                            Type = result.Type,
                            City = city.Name
                        });
                    }
                }
            }
            return oPlaces;
        }


        //String grada za prikaz u naslovu forme FormSearchedPlaces
        public string SearchedCity(string comboGrad)
        {
            string labelGrad;
            if (comboGrad.EndsWith("ka"))
            {
                labelGrad = Regex.Replace(comboGrad, "..$", "ci");
            }
            else if (comboGrad.EndsWith("a"))
            {
                labelGrad = Regex.Replace(comboGrad, ".$", "i");
            }
            else if (comboGrad.EndsWith("Brod"))
            {
                labelGrad = "Slavonskom Brodu";
            }
            else if (comboGrad.EndsWith("ac"))
            {
                labelGrad = Regex.Replace(comboGrad, "..$", "cu");
            }
            else if (comboGrad.EndsWith("ar"))
            {
                labelGrad = Regex.Replace(comboGrad, "..$", "ru");
            }
            else
            {
                labelGrad = comboGrad + "u";
            }
            return labelGrad;
        }
    }
}
