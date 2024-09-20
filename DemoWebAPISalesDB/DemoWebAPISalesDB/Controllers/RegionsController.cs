using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebAPISalesDB.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase {
        public static List<string> regions = new();
        [HttpGet]
        public List<string> GetAll() {
            if (regions.Count == 0)
                return new List<string> {"No regions in list... yet :)" };
            else
                return regions;
        }

        [HttpPost]

    }
}
