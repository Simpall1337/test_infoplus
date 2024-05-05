using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IEquipmentRepository 
    {
        public IEnumerable<Equipment> GetEquipment(int id);
        public IEnumerable<Equipment> AddEquipment(Equipment equipment);
        public void UpdateEquipment(Equipment equipment);
        public void DeleteEquipment(int id);
    }
}
