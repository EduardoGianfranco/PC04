using Microsoft.AspNetCore.Mvc;
using PC04.Models;

namespace PC04.Controllers
{
    public class FailsController : Controller
    {
        private readonly PracticaContext _context;

        public FailsController(PracticaContext context)
        {
            _context = context;
        }

        public IActionResult SubirFail(){
            return View();
        }
        [HttpPost]
        public IActionResult SubirFail(Fail f){
            if(ModelState.IsValid){
                _context.TFail.Add(f);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }else{
                return View(f);
            }
        }
    }
}