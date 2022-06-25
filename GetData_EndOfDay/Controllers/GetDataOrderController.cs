using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GetData_EndOfDay.Data;
using GetData_EndOfDay.Models;

namespace GetData_EndOfDay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetDataOrderController : ControllerBase
    {
        private readonly DataContext _db;

        public GetDataOrderController(DataContext db)
        {
            _db = db;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<ActionResult<List<DataOrderDTO>>> Get()
        {
            System.Console.WriteLine("Hello World!");
            return Ok(await _db.DataOrderDTOs.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<DataOrderDTO>>> AddListHero(List<Models.DataOrderDTO> list)
        {
            var hero = new DataOrderDTO();

            for (int i = 0; i < list.Count; i++)
            {
                _db.DataOrderDTOs.Add(list[i]);
            }

            await _db.SaveChangesAsync();

            return Ok(await _db.DataOrderDTOs.ToListAsync());
        }
    }
}
