using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace DataAccessLayer
{
    public class GooglePlaceRepository
    {
        private List<GooglePlace> _googlePlaces = new List<GooglePlace>();
        string url = "";
        /*public GooglePlaceRepository()
        {
            string json = CallRestMethod(url);

            JArray jsonObject = JArray.Parse(json);
            JToken results = jsonObject.SelectToken("results");

            foreach (JObject place in results)
            {

                _googlePlaces.Add(
                    new GooglePlace
                    {
                        Id = (int)place.GetValue("id"),
                        Name = (string)place.GetValue("name"),
                        Lat = (double)place.SelectToken("geometry.location.lat"),
                        Lng = (double)place.SelectToken("geometry.location.lng")
                    });
            }
        }*/
        public GooglePlaceRepository()
        {
            JObject json = JObject.Parse(File.ReadAllText("C:/Users/student/Downloads/example.json"));
            
            JToken results = json["results"];

            foreach (JObject place in results)
            {
                _googlePlaces.Add(
                    new GooglePlace
                    {
                        Id = (int)place.GetValue("id"),
                        Name = (string)place.GetValue("name"),
                        Lat = (double)place.GetValue("[geometry][location][lat]"),
                        //Lng = (double)place.SelectToken("geometry.location.lng")
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
