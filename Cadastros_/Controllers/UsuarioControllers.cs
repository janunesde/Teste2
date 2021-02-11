
using Cadastros.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cadastros.Controllers
{
    public class UsuarioControllers : Controller
    {
        public IActionResult Cadastro(){
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Usuario u){
            UsuarioRepository ur = new UsuarioRepository();
            ur.Insert(u);
            ViewBag.Mensagem = "Usuário Cadastrado com sucesso!";
            return View();
        }
    }
}