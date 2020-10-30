using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeCheck.Models;
using PracticeCheck.Repository;

namespace PracticeCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        public IItemRepository repo;
        public ItemController(IItemRepository repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        [Route("GetAllItems")]
        public IActionResult GetAllItems()
        {
            try
            {
                var items = repo.GetItems().ToList();
                if (items.Count == 0)
                {
                    return BadRequest("No Flights");
                }
                return Ok(items);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("AddItem")]
        public IActionResult AddItem([FromBody]Item item)
        {
            try
            {
                var res = repo.AddItem(item);
                if (res == 0)
                {
                    return BadRequest();
                }
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}