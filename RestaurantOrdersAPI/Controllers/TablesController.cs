using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantOrdersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {

        private readonly IDataContext _context;

        public TablesController(IDataContext context)
        {
            _context = context;
        }


        // GET: api/<TablesController>================================
        [HttpGet]
        public IEnumerable<Table> Get()
        {
            return _context.Tables;

        }

        // GET api/<TablesController>/5=====================================
        [HttpGet("{id}")]
        public ActionResult<Table> Get(int id)
        {
            var table = _context.Tables.FirstOrDefault(c => c.Id == id);
            return table != null ? Ok(table) : NotFound();
        }

        // POST api/<TablesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TablesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TablesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
