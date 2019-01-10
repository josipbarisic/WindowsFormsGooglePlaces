using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Newtonsoft.Json.Linq;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //TYPES
            var repoTypes = new TypeRepository();
            DataAccessLayer.Type typeObject = new DataAccessLayer.Type { sType = "hospital", sTypeView = "Hospital", sIcon = "" };
            repoTypes.AddType(typeObject);

            //PLACES
            /*Console.WriteLine("Unesi radius:");
            int radius = Convert.ToInt32(Console.ReadLine());
            */
            Console.WriteLine("OK");
            //var tip = Convert.ToString(Console.ReadLine());

            /*Console.WriteLine("Unesi ime:");
            var ime = Convert.ToString(Console.ReadLine());*/

            /*Console.WriteLine("Unesi latitudu:");
            double latituda = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesi longitudu:");
            double longituda = Convert.ToDouble(Console.ReadLine());*/
            var repo = new GooglePlaceRepository();
            //var getall = repo.SearchPlace(5000, tip, -33.9, 151.19);
            List<string> tipovi = new List<string>();
            //repo.DeletePlace(ime);
            /*foreach (var pl in getall)
            {
                repo.AddPlace(pl, "food");
                Console.WriteLine(pl.Name);
                Console.WriteLine("Tipovi: ");
                foreach(var type in pl.Type)
                {
                    Console.WriteLine(type);
                }
                Console.WriteLine("\n");
            }*/
            Console.ReadKey();
        }
    }
}

//PONAVLJAJU SE VRIJEDNOSTI ID, TYPE RADI SAMO ZA JEDNO MJESTO (GooglePlaceRepository AddPlace funckija)
//U DATAGRID-U SE NE MOZE ISPISAT TIP MJESTA ()