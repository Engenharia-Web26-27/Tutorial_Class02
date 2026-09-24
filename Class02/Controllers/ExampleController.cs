using Microsoft.AspNetCore.Mvc;

namespace Class02.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection formData)
        {
            // action used to process the the form submitted
            ViewData["text_inserted"] = formData["name"]; //transfer data to the view
            ViewData["other_text_inserted"] = formData["age"]; // transfer data to the view

            return View("Index2"); // uses another view instead using the default view name
                                   // (usualy has the same name as the method - Index)
        }
    }
}
