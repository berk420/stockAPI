using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stockAPI.Model;
using stockAPI.Data;
namespace stockAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockValuesController : ControllerBase
    {
        private readonly ApiContext _Context;

        public StockValuesController(ApiContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task <ActionResult<IEnumerable<stockmodel>>> GetAll()
        {
            return await _Context.stocks.ToListAsync();
        }

    }
}
