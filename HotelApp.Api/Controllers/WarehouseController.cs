using HotelApp.Data.Abstract;
using HotelApp.Services.Abstract;
using HotelManagementApp.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }
        [HttpGet]
        public IActionResult WarehouseList()
        {
            var values = _warehouseService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddWarehouse(WarehouseEntity category)
        {
            _warehouseService.TInsert(category);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWarehouse(int id)
        {
            var value = _warehouseService.TGetByID(id);
            _warehouseService.TDelete(value);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetWarehouse(int id)
        {
            var value = _warehouseService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateWarehouse(WarehouseEntity category)
        {
            _warehouseService.TUpdate(category);
            return Ok();
        }
    }
}

