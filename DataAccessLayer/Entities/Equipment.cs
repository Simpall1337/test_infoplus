using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Equipment
    {
        public int Equipment_ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Specifications { get; set; }
        public decimal Price { get; set; }
    }
}
