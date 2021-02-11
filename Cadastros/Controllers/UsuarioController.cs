using System.Collections.Generic;
using Cadastros.Models;
using Microsoft.AspNetCore.Mvc;
namespace Cadastros.Controllers
{
    public class UsuarioController : Controller
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
        public IActionResult Listar()
        {
            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> usuarios = ur.Query();
            return View(usuarios);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Usuario u)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.QueryLogin(u);
            if(usuario != null)
            {
                ViewBag.Mensagem = "Você está logado";
                return Redirect("Cadastro");
            }
            else
            {
                ViewBag.Mensagem = "Falha no Login";
                return View();
            }
        }
    }
}