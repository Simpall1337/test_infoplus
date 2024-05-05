using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicLayer
{
    public class StoresServise : IStoresServise
    {
        private readonly IStoresRepository _serviceReposetory;
        public StoresServise(IStoresRepository serviceReposetory)
        {
            _serviceReposetory = serviceReposetory;
        }
        public IEnumerable<Stores> GetStores(int id)
        {
            return _serviceReposetory.GetStores(id);
        }
        public IEnumerable<Stores> AddStores(Stores stores)
        {
            return _serviceReposetory.AddStores(stores);
        }
        public void UpdateStores(Stores stores)
        {
            _serviceReposetory.UpdateStores(stores);
        }
        public void DeleteStores(int id)
        {
            _serviceReposetory.DeleteStores(id);
        }
    }
}
