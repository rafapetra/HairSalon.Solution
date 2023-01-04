using Microsoft.AspNetCore.Mvc;

namespace ClaireSalon.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}