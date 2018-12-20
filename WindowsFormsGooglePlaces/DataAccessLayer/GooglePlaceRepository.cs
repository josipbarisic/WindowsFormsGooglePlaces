﻿using System.Collections.Generic;
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
    public class GooglePlaceRepository
    {

        public GooglePlaceRepository()
        {
            //
        }

        public List<GooglePlace> _googlePlaces = new List<GooglePlace>();

        public List<GooglePlace> SearchPlace(int radius, string type, double lat, double lng)
        {

            string json = CallRestMethod(GenerateUrl(radius,type,lat,lng));
            JObject jsonObject = JObject.Parse(json);
            JToken results = jsonObject.SelectToken("results");

            foreach (JObject place in results)
            {
                List<string> tipovi = new List<string>();
                foreach(string poljeTypes in place.GetValue("types"))
                {
                    tipovi.Add(poljeTypes);
                }

                _googlePlaces.Add(
                    new GooglePlace
                    {
                        Id = (string)place.GetValue("id"),
                        Name = (string)place.GetValue("name"),
                        Lat = (decimal)place.SelectToken("geometry.location.lat"),
                        Lng = (decimal)place.SelectToken("geometry.location.lng"),
                        Type = tipovi
                    });
            }
            return _googlePlaces;
        }
        //Metoda za izradu url-a
        public string GenerateUrl(int radius, string type, double lat, double lng)
        {
            var url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location="+ lat + ","+ lng +"&radius="+ radius +"&type="+ type +"&key=AIzaSyDqRf_8ncNpVfYKi4VsHlsC7BzVjCC716s";
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

        public void AddPlace(GooglePlace place, string tajp)
        {
            string sSqlConnectionString = "Data Source = 193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                string types = "";
                foreach (var tip in place.Type)
                {
                    if(tip == tajp)
                    {
                        types = tip;
                    }
                }
                oCommand.CommandText = "INSERT INTO GooglePlaces_Places (Id, Name, Lat, Lng, Type) VALUES  ('" + place.Id + "', '" + place.Name + "', '" + place.Lat + "', '" + place.Lng + "', '" + types + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    oReader.Read();
                }
            }
        }

        public void DeletePlace(string naziv)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM GooglePlaces_Places WHERE Name = '" + naziv + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    oReader.Read();
                }
            }
        }
    }
}
