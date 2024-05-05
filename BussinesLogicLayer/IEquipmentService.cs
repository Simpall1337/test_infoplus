using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicLayer
{
    public interface IEquipmentService
    {
        public IEnumerable<Equipment> GetEquipment(int id);
        public IEnumerable<Equipment> AddEquipment(Equipment stores);
        public void UpdateEquipment(Equipment stores);
        public void DeleteEquipment(int id);
    }
}
