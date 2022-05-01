using Microsoft.AspNetCore.Mvc;
using MyCar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCar.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    
    public class CarsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CarsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        []
        public async Task<IActionResult> GetCars()
        {
            return Ok
            (new
            {
                sucess = true,
                data = await _appDbContext.Cars.ToListAsync()
            });      
        }
    }
}
