using Microsoft.AspNetCore.Mvc;

namespace Timepage.Controllers
{
    public class Timepage : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}
