using HotelApp.Data.Abstract;
using HotelApp.Services.Abstract;
using HotelManagementApp.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BuildingController : ControllerBase
    {
        private readonly IBuildingService _buildingService;

        public BuildingController(IBuildingService buildingService)
        {
            _buildingService = buildingService;
        }
        [HttpGet]
        public IActionResult BuildingList()
        {
            var values = _buildingService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBuilding(BuildingEntity category)
        {
            _buildingService.TInsert(category);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBuilding(int id)
        {
            var value = _buildingService.TGetByID(id);
            _buildingService.TDelete(value);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBuilding(int id)
        {
            var value = _buildingService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateBuilding(BuildingEntity category)
        {
            _buildingService.TUpdate(category);
            return Ok();
        }
    }
}

