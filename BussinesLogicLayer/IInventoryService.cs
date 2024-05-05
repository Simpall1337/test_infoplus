using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicLayer
{
    public interface IInventoryService
    {
        public IEnumerable<Inventory> GetInventory(int id);
        public IEnumerable<Inventory> AddInventory(Inventory inventory);
        public void UpdateInventory(Inventory inventory);
        public void DeleteInventory(int id);
    }
}
