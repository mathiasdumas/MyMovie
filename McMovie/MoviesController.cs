using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class MoviesController : Controller
    {
        // GET: MoviesController
        public ActionResult Index()
        {
            return View();
        }

    }
}
