using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using BussinesLogicLayer;
namespace test_infoplus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;

        public EquipmentController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        [HttpGet]
        public IActionResult GetEquipment(int id)
        {
            var getEquipment = _equipmentService.GetEquipment(id);
            return Ok(getEquipment);
        }
        [HttpPost]
        public IActionResult AddEquipment(Equipment equipment)
        {
            try
            {
                var addEquipment = _equipmentService.AddEquipment(equipment);
                return Ok(addEquipment);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPatch]
        public IActionResult UpdateEquipment(Equipment equipment)
        {
            try
            {
                _equipmentService.UpdateEquipment(equipment);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteEquipment(int id)
        {
            try
            {
                _equipmentService.DeleteEquipment(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
