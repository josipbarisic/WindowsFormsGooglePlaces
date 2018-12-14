using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unos url-a
            Console.WriteLine("Unesi radius:");
            var radius = Console.ReadLine();
            Console.WriteLine("Unesi tip:");
            var tip = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Unesi latitudu:");
            var latituda = Console.ReadLine();
            Console.WriteLine("Unesi longitudu:");
            var longituda = Console.ReadLine();

            var url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location="+ latituda + ","+ longituda +"&radius="+ radius +"&type="+ tip +"&key=AIzaSyDqRf_8ncNpVfYKi4VsHlsC7BzVjCC716s";

            var repo = new GooglePlaceRepository(url);
            var place = repo.GetAll();
            foreach(var pl in place)
            {
                Console.WriteLine(pl.Name);
            }
            Console.ReadKey();
        }
    }
}
