using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Service;

namespace OnlineHotelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly InventoryService S_inventory;

        public InventoryController(InventoryService inventory)
        {
            S_inventory = inventory;
        }

        [HttpPost("InsertInventory"), Authorize(Roles = "Manager")]
        public IActionResult InsertInventory(Inventory inventory)
        {
            return Ok(S_inventory.InsertInventory(inventory));
        }

        [HttpDelete("DeleteInventory"), Authorize(Roles = "Manager")]
        public IActionResult DeleteInventory(int Id)
        {
            return Ok(S_inventory.DeleteInventory(Id));
        }

        [HttpPut("UpdateInventory"), Authorize(Roles = "Manager")]
        public IActionResult UpdateInventory(Inventory inventory)
        {
            return Ok(S_inventory.UpdateInventory(inventory));
        }

        [HttpGet("GetInventoryById"), Authorize(Roles = "Manager")]
        public IActionResult GetInventoryById(int Id)
        {
            return Ok(S_inventory.GetInventoryById(Id));
        }
    }
}
