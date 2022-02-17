using Microsoft.AspNetCore.Mvc;

namespace fiap_web_2022.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Nome"] = "Fillipe";
            ViewBag.Sobrenome = "Augusto";

            var model = new Aluno() { Nome = "José", Sobrenome = "Silva" };

            return View("home", model);
        }

        [HttpPost]
        public IActionResult Index([FromBody] Aluno aluno)
        {
            return View(aluno);
        }


        //public string Index()
        //{
        //    return "boa noite";
        //}
    }
}
