using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GooglePlace
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
    }
}
