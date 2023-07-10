using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace MvcDogFriendlyPlaces.Controllers
{
    public class DogFriendlyPlacesController : Controller
    {
          public IActionResult Index()
        {
         return View();
        }

        // GET: /DogFriendlyPlaces/
        //  public string Index()
        //{
        //   return "This is my default action...";
        //}
        // 
        // GET: /DogFriendlyPlaces/Welcome/ 
        //https://localhost:{PORT}/DogFriendlyPlaces/Welcome?name=Madde&numtimes=4. 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
    
}
