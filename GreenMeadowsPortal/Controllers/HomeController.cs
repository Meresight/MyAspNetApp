using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GreenMeadowsPortal.Controllers
{
    [Authorize] // This ensures only logged-in users can access
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}