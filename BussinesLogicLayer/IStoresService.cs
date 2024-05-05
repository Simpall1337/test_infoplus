using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces
{
    public interface IStoresServise
    {
        public IEnumerable<Stores> GetStores(int id);
        public IEnumerable<Stores> AddStores(Stores stores);
        public void UpdateStores(Stores stores);
        public void DeleteStores(int id);
    }
}
