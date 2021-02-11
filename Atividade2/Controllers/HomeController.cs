using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade2.Models;
using Microsoft.AspNetCore.Http;


namespace Atividade2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login(){
            return View();
        }
         [HttpPost]

        public IActionResult Login(Usuario u){
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.Login(u);

            //Session - Variáveis
            if (usuario != null){
                HttpContext.Session.SetInt32("Id",usuario.Id);
                HttpContext.Session.SetString("Nome",usuario.Nome);
                HttpContext.Session.SetInt32("Tipo",usuario.Tipo);
                return Redirect("Logado");
            } else{
                ViewBag.Mensagem ="Erro, usuário ou senha invalidos!";
                return View();
            }
        }

        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return View("Logout");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
