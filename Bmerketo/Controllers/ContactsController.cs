using Bmerketo.Models.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace Bmerketo.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index(string ReturnUrl = null!)
        {
            var form = new ContactForm { ReturnUrl = ReturnUrl ?? Url.Content("~/") };
            return View(form);
        }
        [HttpPost]
        public IActionResult Index(ContactForm form)
        {
            return View();
        }
    }
}
