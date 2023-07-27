using Microsoft.AspNetCore.Mvc;

namespace ApiCidades.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("HandShake")]
        public string HandShake()
        {
            return "ok";
        }
    }
}
