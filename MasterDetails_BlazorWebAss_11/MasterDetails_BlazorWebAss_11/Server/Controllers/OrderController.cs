using MasterDetails_BlazorWebAss_11.Server.Models;
using MasterDetails_BlazorWebAss_11.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MasterDetails_BlazorWebAss_11.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly MyDbContext _context;
        public OrderController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<List<Order>> GetOrders()
        {
            return await _context.Orders.Include(o => o.Items).ToListAsync();

        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetOrder(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var order = await _context.Orders.Include(o => o.Items).FirstOrDefaultAsync(o => o.OrderId == id);
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Order order)
        {
            if (order == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
                return Ok();

            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Order order)
        {

            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
            return BadRequest();

        }

        [HttpGet("products")]
        public async Task<List<Product>> Product()
        {
         return  await _context.Products.ToListAsync();

        }

    }
}
