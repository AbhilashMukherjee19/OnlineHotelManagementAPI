using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Service;

namespace OnlineHotelManagementAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly InventoryService S_inventory;

        private HotelContext _context;

        public InventoryController(InventoryService inventory, HotelContext context)
        {
            S_inventory = inventory;
            _context = context;
        }

        #region InsertInventory
        [HttpPost("InsertInventory")/*, Authorize(Roles = "Manager, Owner")*/]
        public IActionResult InsertInventory(Inventory inventory)
        {
            return Ok(S_inventory.InsertInventory(inventory));
        }
        #endregion

        #region UpdateInventory
        [HttpPut("UpdateInventory")/*, Authorize(Roles = "Manager, Owner")*/]
        public IActionResult UpdateInventory(Inventory inventory)
        {
            return Ok(S_inventory.UpdateInventory(inventory));
        }
        #endregion

        #region DeleteInventory
        [HttpDelete("DeleteInventory")/*, Authorize(Roles = "Manager, Owner")*/]
        public IActionResult DeleteInventory(int Id)
        {
            return Ok(S_inventory.DeleteInventory(Id));
        }
        #endregion

        #region GetInventoryById
        [HttpGet("GetInventoryById")/*, Authorize(Roles = "Manager, Owner")*/]
        public IActionResult GetInventoryById(int Id)
        {
            if (S_inventory.GetInventoryById(Id) == "200")
            {
                return Ok(_context.Inventoriess.Find(Id));
            }
            else
            {
                return Ok(new { message = "Not Found" });
            }
        }
        #endregion

        #region GetAllInventories
        [HttpGet("GetAllInventories")/*, Authorize(Roles = "Manager, Owner")*/]
        public IActionResult GetAllInventories()
        {
            return Ok(S_inventory.GetAllInventories());
        }
        #endregion
    }
}
