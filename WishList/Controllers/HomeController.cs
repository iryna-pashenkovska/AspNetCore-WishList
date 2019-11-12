using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    [Produces("application/json")]
    [Route("api/Home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
