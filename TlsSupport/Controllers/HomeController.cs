using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TlsSupport.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "Home Page";

            var response = await new HttpClient().GetAsync("https://www.damirscorner.com");

            return View();
        }
    }
}
