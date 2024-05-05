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
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly DbConnect _dbConnect;
        SqlEquipment sql = new SqlEquipment();
        public EquipmentRepository(DbConnect dbConnect)
        {

            _dbConnect = dbConnect;
        }
        public IEnumerable<Equipment> GetEquipment(int id)
        {
            return _dbConnect.GetConnection().Query<Equipment>(sql.getEquipment, new { Id = id });
        }
        public IEnumerable<Equipment> AddEquipment(Equipment equipment)
        {
            return _dbConnect.GetConnection().Query<Equipment>(sql.addEquipment, new
            {
                Equipment_ID = equipment.Equipment_ID,
                Name = equipment.Name,
                Type = equipment.Type,
                Specifications = equipment.Specifications,
                Price = equipment.Price
            });
        }
        public void UpdateEquipment(Equipment equipment)
        {
            _dbConnect.GetConnection().Query<Equipment>(sql.updEquipment, new
            {
                Equipment_ID = equipment.Equipment_ID,
                Name = equipment.Name,
                Type = equipment.Type,
                Specifications = equipment.Specifications,
                Price = equipment.Price
            });
        }
        public void DeleteEquipment(int id)
        {
            _dbConnect.GetConnection().Query<Stores>(sql.delEquipment, new
            {
                Equipment_ID = id
            });
        }
    }
}
