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

            /*foreach(var ggg in getall)
            {
                Console.WriteLine(ggg.Name+" SPACE "+ggg.Type);
            }*/

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
            var gradTip = repo.GetCityPlaces(grad, tip);
            
            foreach(var gradT in gradTip)
            {
                repo.AddPlace(gradT);
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