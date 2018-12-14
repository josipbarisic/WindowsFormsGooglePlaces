using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DataAccessLayer
{
    public class GooglePlaceRepository
    {
        private List<GooglePlace> _googlePlaces = new List<GooglePlace>();


        public GooglePlaceRepository(string url /*,string type*/)
        {
            string json = CallRestMethod(url);

            JObject jsonObject = JObject.Parse(json);
            JToken results = jsonObject.SelectToken("results");

            foreach (JObject place in results)
            {

                _googlePlaces.Add(
                    new GooglePlace
                    {
                        Id = (string)place.GetValue("id"),
                        Name = (string)place.GetValue("name"),
                        Lat = (double)place.SelectToken("geometry.location.lat"),
                        Lng = (double)place.SelectToken("geometry.location.lng"),
                        //Type= type
                    });
            }
        }
        

        public List<GooglePlace> GetAll()
        {
            return _googlePlaces;
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
    }
}
