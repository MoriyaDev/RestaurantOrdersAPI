using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantOrdersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private readonly IDataContext _context;

        public OrdersController(IDataContext context)
        {
            _context = context;
        }


        // GET: api/<OrdersController>=======================================
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _context.Orders;

        }

        // GET api/<OrdersController>/5===============================
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            var order = _context.Orders.FirstOrDefault(c => c.Id == id);
            return order != null ? Ok(order) : NotFound();
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
