using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Inventory
    {
        public int Inventory_ID { get; set; }
        public int Equipment_ID { get; set; }
        public int Store_ID { get; set; }
        public int Stock { get; set; }
    }
}
