using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicLayer
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IEquipmentRepository _equipmentReposetory;
        public EquipmentService(IEquipmentRepository equipmentReposetory)
        {
            _equipmentReposetory = equipmentReposetory;
        }
        public IEnumerable<Equipment> GetEquipment(int id)
        {
            return _equipmentReposetory.GetEquipment(id);
        }
        public IEnumerable<Equipment> AddEquipment(Equipment stores)
        {
            return _equipmentReposetory.AddEquipment(stores);
        }
        public void UpdateEquipment(Equipment equipment)
        {
            _equipmentReposetory.UpdateEquipment(equipment);
        }
        public void DeleteEquipment(int id)
        {
            _equipmentReposetory.DeleteEquipment(id);
        }

    }
}
