using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using Microsoft.Data.SqlClient;
using DataAccessLayer.Data;
using DataAccessLayer.Interfaces;
using BussinesLogicLayer;
using DataAccessLayer.Entities;

namespace test_infoplus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoresServise _storeService;

        public StoreController(IStoresServise storeService)
        {
            _storeService = storeService;
        }

        [HttpGet]
        public IActionResult GetStore(int id)
        { 
            var getStores = _storeService.GetStores(id);
            return Ok(getStores);
        }

        [HttpPost]
        public IActionResult AddStore(Stores store)
        {
            try
            {
                var addStore = _storeService.AddStores(store);
                return Ok(addStore);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch]
        public IActionResult UpdateStore(Stores store)
        {
            try
            {
                _storeService.UpdateStores(store);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteStore(int id)
        {
            try
            {
                _storeService.DeleteStores(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
