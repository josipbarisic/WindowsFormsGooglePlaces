using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Newtonsoft.Json.Linq;
using System.Net;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OK");
            //TYPES
            /*var repoTypes = new TypeRepository();
            DataAccessLayer.Type typeObject = new DataAccessLayer.Type { sType = "hospital", sTypeView = "Hospital", sIcon = "" };*/
            //repoTypes.AddType(typeObject);

            //PLACES

            //PRETRAZI MJESTA
            /*Console.WriteLine("Unesi radius:");
            int radius = Convert.ToInt32(Console.ReadLine());
            */
            //Console.WriteLine("Unesi tip");
            //var tip = Convert.ToString(Console.ReadLine());

            /*Console.WriteLine("Unesi latitudu:");
            double latituda = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesi longitudu:");
            double longituda = Convert.ToDouble(Console.ReadLine());*/

            var repo = new GooglePlaceRepository();
            //var getall = repo.SearchPlace("bus_station", 45.841820, 17.388466);

            //PRETRAGA MJESTA PO GRADU
            //var mjesta = repo.GetCityPlaces("Zagreb","political");

            //DOHVATI ODABRANI TIP
            var repoTypes = new TypeRepository();
            //var getTypes = repoTypes.GetSelectedType("Airport");
            //Console.WriteLine(getTypes);

            Console.WriteLine("Unesite grad i tip: ");
            var grad = Console.ReadLine();
            var tip = Convert.ToString(Console.ReadLine());


            //DOHVATI GRADOVE IZ BP
            var repoG = new CityRepository();
            var getCities = repoG.GetCities();

            //PRETRAGA MJESTA PO GRADU I TIPU
            foreach (var city in getCities)
            {
                if(String.Equals(grad, city.Name, StringComparison.OrdinalIgnoreCase))
                {
                    var search = repo.SearchPlace(tip, (double)city.Latitude, (double)city.Longitude);
                    foreach(var place1 in search)
                    {
                        Console.WriteLine(place1.Name+"     Lat: "+place1.Lat+"     Lng:"+place1.Lng);
                    }
                }  
            }
            

            //OBRISI MJESTO
            /*Console.WriteLine("Unesi ime:");
            var ime = Convert.ToString(Console.ReadLine());*/
            //repo.DeletePlace(ime);

            
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}

//PONAVLJAJU SE VRIJEDNOSTI ID, TYPE RADI SAMO ZA JEDNO MJESTO (GooglePlaceRepository AddPlace funckija)
//U DATAGRID-U SE NE MOZE ISPISAT TIP MJESTA ()