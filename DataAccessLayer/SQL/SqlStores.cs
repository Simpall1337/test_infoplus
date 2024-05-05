using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SQL
{
    public class SqlStores
    {
        public readonly string getStores = "SELECT * FROM Stores WHERE (Store_id = @Id or 0 = @Id)";
        public readonly string addStores = "INSERT INTO Stores VALUES (@Store_ID,@Name, @Location,@Contact_Info);";
        public readonly string updStores = "UPDATE Stores SET Name = @Name, Location = @Location,Contact_Info = @Contact_Info WHERE Store_ID = @Store_ID";
        public readonly string delStores = "DELETE FROM Stores WHERE Store_ID = @Store_ID";
    }
}
