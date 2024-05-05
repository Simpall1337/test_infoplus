using BussinesLogicLayer;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace test_infoplus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpGet]
        public IActionResult GetInventory(int id)
        {
            var getInventory = _inventoryService.GetInventory(id);
            return Ok(getInventory);
        }
        [HttpPost]
        public IActionResult AddInventory(Inventory inventory)
        {
            try
            {
                var addInventory = _inventoryService.AddInventory(inventory);
                return Ok(addInventory);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPatch]
        public IActionResult UpdateInventory(Inventory inventory)
        {
            try
            {
                _inventoryService.UpdateInventory(inventory);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteInventory(int id)
        {
            try
            {
                _inventoryService.DeleteInventory(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
