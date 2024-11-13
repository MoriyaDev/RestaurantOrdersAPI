using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantOrdersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IDataContext _context;

        public CustomersController(IDataContext context)
        {
            _context = context;
        }


        // GET: api/<CustomersController>========================
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.Customers;
        }

        // GET api/<CustomersController>/5=============================
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            return customer != null ? Ok(customer) : NotFound();
        }

        // POST api/<CustomersController>========================
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
