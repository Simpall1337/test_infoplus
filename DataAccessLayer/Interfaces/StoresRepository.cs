using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using DataAccessLayer.SQL;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DataAccessLayer.Interfaces
{
    public class StoresRepository : IStoresRepository
    {
        private readonly DbConnect _dbConnect;
        SqlStores sql = new SqlStores();
        public StoresRepository(DbConnect dbConnect)
        {
           
            _dbConnect = dbConnect;
        }
        public IEnumerable<Stores> GetStores(int id)
        {
            return _dbConnect.GetConnection().Query<Stores>(sql.getStores, new {Id = id });
        }
        public IEnumerable<Stores> AddStores(Stores stores)
        {
            return _dbConnect.GetConnection().Query<Stores>(sql.addStores, new {
                Store_ID = stores.Store_ID,
                Name = stores.Name,
                Location = stores.Location,
                Contact_Info = stores.Contact_Info,
            });
        }
        public void UpdateStores(Stores stores)
        {
            _dbConnect.GetConnection().Query<Stores>(sql.updStores, new
            {
                Store_ID = stores.Store_ID,
                Name = stores.Name,
                Location = stores.Location,
                Contact_Info = stores.Contact_Info,
            });
        }
        public void DeleteStores(int id)
        {
            _dbConnect.GetConnection().Query<Stores>(sql.delStores, new
            {
                Store_ID = id
            });
        }
    }
}
