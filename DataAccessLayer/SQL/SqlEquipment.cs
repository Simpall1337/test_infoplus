using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SQL
{
    public class SqlEquipment
    {
        public readonly string getEquipment = "SELECT * FROM Equipment WHERE (Equipment_id = @Id or 0 = @Id)";
        public readonly string addEquipment = "INSERT INTO Equipment VALUES (@Equipment_id,@Name, @Type,@Specifications,@Price);";
        public readonly string updEquipment = "UPDATE Equipment SET Name = @Name, Type = @Type,Specifications = @Specifications,Price = @Price WHERE Equipment_id = @Equipment_id";
        public readonly string delEquipment = "DELETE FROM Equipment WHERE Equipment_id = @Equipment_id";
    }
}
