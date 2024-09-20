using DemoWebAPIEFSalesDb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoWebAPIEFSalesDb.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase {

        // define dbContext
        private readonly SalesDBContext _salesDBContext;

        public RegionsController(SalesDBContext salesDBContext) {
            _salesDBContext = salesDBContext;
        }

        public async Task<ActionResult<IEnumerable<Region>>> GetRegions() {
            return await _salesDBContext.Regions.ToListAsync();
        }

    }
}
