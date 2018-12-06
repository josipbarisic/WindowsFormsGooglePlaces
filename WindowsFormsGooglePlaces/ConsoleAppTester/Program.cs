using System;
using System.Collections.Generic;
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
            var repo = new GooglePlaceRepository();
            var place = repo.GetAll();
            foreach(var pl in place)
            {
                Console.WriteLine(pl.Name);
            }
            Console.ReadKey();
        }
    }
}
