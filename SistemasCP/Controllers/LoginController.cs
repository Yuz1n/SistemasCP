using Microsoft.AspNetCore.Mvc;
using SistemasCP.Models;

namespace SistemasCP.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Logar(User User)
        {
            try
            {
                if (ModelState.IsValid)
                {
                 return RedirectToAction("Index", "Home");
                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MesagemErro"] = $"Não conseguimos realizar seu login! : {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
