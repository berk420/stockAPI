using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stockAPI.Model;
using stockAPI.Data;

namespace stockAPI.Controllers // Buradaki değişiklik "Controllers"
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockValuesController : ControllerBase
    {
        private readonly ApiContext _context;

        public StockValuesController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public JsonResult GetData(string deger)
        {
            var result = _context.bilanco.Find(deger);
            if (result == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(result));
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var result = _context.bilanco.ToList();
            return new JsonResult(Ok(result));
        }

    }
}