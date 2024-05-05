using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SQL
{
    public class SqlInventory
    {
        public readonly string getInventory = "SELECT * FROM Inventory WHERE (Inventory_id = @Id or 0 = @Id)";
        public readonly string addInventory = "INSERT INTO Inventory VALUES (@Inventory_ID,@equipment_ID, @store_ID,@stock);";
        public readonly string updInventory = "UPDATE Inventory SET equipment_ID = @equipment_ID, store_ID = @store_ID,stock = @stock WHERE Inventory_ID = @Inventory_ID";
        public readonly string delInventory = "DELETE FROM Inventory WHERE Inventory_ID = @Inventory_ID";
    }
}
