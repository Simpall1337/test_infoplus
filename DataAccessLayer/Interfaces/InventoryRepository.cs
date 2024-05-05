using Dapper;
using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using DataAccessLayer.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly DbConnect _dbConnect;
        SqlInventory sql = new SqlInventory();
        public InventoryRepository(DbConnect dbConnect)
        {
            _dbConnect = dbConnect;
        }
        public IEnumerable<Inventory> GetInventory(int id)
        {
            return _dbConnect.GetConnection().Query<Inventory>(sql.getInventory, new { Id = id });
        }
        public IEnumerable<Inventory> AddInventory(Inventory inventory)
        {
            return _dbConnect.GetConnection().Query<Inventory>(sql.addInventory, new
            {
                Inventory_ID = inventory.Inventory_ID,
                Equipment_ID = inventory.Equipment_ID,
                Store_ID = inventory.Store_ID,
                Stock = inventory.Stock
            });
        }
        public void UpdateInventory(Inventory inventory)
        {
            _dbConnect.GetConnection().Query<Inventory>(sql.updInventory, new
            {
                Inventory_ID = inventory.Inventory_ID,
                Equipment_ID = inventory.Equipment_ID,
                Store_ID = inventory.Store_ID,
                Stock = inventory.Stock
            });
        }
        public void DeleteInventory(int id)
        {
            _dbConnect.GetConnection().Query<Inventory>(sql.delInventory, new 
            { 
                Inventory_ID = id 
            });
        }
    }
}
