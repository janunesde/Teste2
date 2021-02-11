using System.Collections.Generic;
using uc04at02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace uc04at02.Controllers
{
    public class UsuarioController : Controller
    {
        //Login formulario em branco
        public IActionResult Login(){
            return View();
        }

        //Login Preenchido
        [HttpPost]
        public IActionResult Login(Usuario u){
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.Login(u);

            if(usuario != null){

                //HttpContext.Session.SetInt32("id",usuario.Id);
                //HttpContext.Session.SetString("Nome",usuario.Nome);
                //HttpContext.Session.SetInt32("tipo",usuario.Tipo);
                ViewBag.Mensagem = "Uhul!!";
                return View();
            }
            else{
                ViewBag.Mensagem = "Erro, Usuário ou Senha Invádos";
                return View();
            }
        }
        public IActionResult Logado(){
            return View();
        }

        public IActionResult Logout(){
           // HttpContext.Session.Clear();
            return View();
        }
        
        [HttpPost]
        public IActionResult Excluir(Usuario u){
            UsuarioRepository ur = new UsuarioRepository();
            ur.Excluir(u);
            return View();
        }

    }
}