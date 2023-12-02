using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookstoreDatabase.Data;
using BookstoreDatabase.Entitites;

namespace BookstoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLineItemsController : ControllerBase
    {
        private readonly BookstoreContext _context;

        public OrderLineItemsController(BookstoreContext context)
        {
            _context = context;
        }

        // GET: api/OrderLineItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderLineItem>>> GetOrderLineItems()
        {
          if (_context.OrderLineItems == null)
          {
              return NotFound();
          }
            return await _context.OrderLineItems.ToListAsync();
        }

        // GET: api/OrderLineItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderLineItem>> GetOrderLineItem(int id)
        {
          if (_context.OrderLineItems == null)
          {
              return NotFound();
          }
            var orderLineItem = await _context.OrderLineItems.FindAsync(id);

            if (orderLineItem == null)
            {
                return NotFound();
            }

            return orderLineItem;
        }

        // PUT: api/OrderLineItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderLineItem(int id, OrderLineItem orderLineItem)
        {
            if (id != orderLineItem.OrderLineItemId)
            {
                return BadRequest();
            }

            _context.Entry(orderLineItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderLineItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderLineItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderLineItem>> PostOrderLineItem(OrderLineItem orderLineItem)
        {
          if (_context.OrderLineItems == null)
          {
              return Problem("Entity set 'BookstoreContext.OrderLineItems'  is null.");
          }
            _context.OrderLineItems.Add(orderLineItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderLineItem", new { id = orderLineItem.OrderLineItemId }, orderLineItem);
        }

        // DELETE: api/OrderLineItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderLineItem(int id)
        {
            if (_context.OrderLineItems == null)
            {
                return NotFound();
            }
            var orderLineItem = await _context.OrderLineItems.FindAsync(id);
            if (orderLineItem == null)
            {
                return NotFound();
            }

            _context.OrderLineItems.Remove(orderLineItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderLineItemExists(int id)
        {
            return (_context.OrderLineItems?.Any(e => e.OrderLineItemId == id)).GetValueOrDefault();
        }
    }
}
