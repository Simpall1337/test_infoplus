using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicLayer
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryReposetory;
        public InventoryService(IInventoryRepository inventoryReposetory)
        {
            _inventoryReposetory = inventoryReposetory;
        }
        public IEnumerable<Inventory> GetInventory(int id)
        {
            return _inventoryReposetory.GetInventory(id);
        }
        public IEnumerable<Inventory> AddInventory(Inventory inventory)
        {
            return _inventoryReposetory.AddInventory(inventory);
        }
        public void UpdateInventory(Inventory inventory)
        {
            _inventoryReposetory.UpdateInventory(inventory);
        }
        public void DeleteInventory(int id)
        {
            _inventoryReposetory.DeleteInventory(id);
        }
    }
}
