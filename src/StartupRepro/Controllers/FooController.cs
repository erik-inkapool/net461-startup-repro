using Microsoft.AspNetCore.Mvc;

namespace StartupRepro.Controllers
{

    [Route("api/[controller]")]
    public class FooController : Controller
    {
        // GET api/foo
        [HttpGet]
        public string Get()
        {
            return "bar!";
        }
    }
}
