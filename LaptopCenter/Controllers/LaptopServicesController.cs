using LaptopCenter.Models;
using LaptopCenter.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaptopCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaptopServicesController : ControllerBase
    {
        private readonly ILaptopServices _laptopservices;

        public LaptopServicesController(ILaptopServices laptopServices)
        {
            _laptopservices = laptopServices;
        }
        [HttpGet]
        public async Task<ActionResult<List<Laptop>>> GetAllLaptops()
        {
            return await _laptopservices.GetAllLaptops();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Laptop>> GetById(int id)
        {
            var laptop =await _laptopservices.GetLaptop(id);
            if (laptop is null)
                return NotFound("This laptop does'nt exit.");
            return Ok(laptop);
        }
        [HttpPost]
        public async Task<ActionResult<List<Laptop>>> AddLaptop(Laptop entity)
        {
            var laptop = await _laptopservices.AddLaptop(entity);
            if (laptop is null)
                return NotFound("It's not possible.Please try apain!");
            return Ok(laptop);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Laptop>>> UpdateLaptop(int id,Laptop req)
        {
            var laptop = await _laptopservices.UpdateLaptop(id, req);
            if (laptop is null)
                return NotFound("It's not possible.Please try apain!");
            return Ok(laptop);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Laptop>> DeleteLaptop(int id)
        {
            var laptop =await _laptopservices.DeleteLaptop(id);
            if (laptop is null)
                return NotFound("It's not possible.Please try apain!");
            return Ok(laptop);

        }
    }
}
