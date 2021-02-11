using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Atividade2.Models;

namespace Atividade2.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Login formulario em branco.
        public IActionResult Login(){
            return View();
        }
         public IActionResult Principal(){
            return View();
        }

        public IActionResult Conectado(){
            return View();
        }


         public IActionResult Viagens(){
            return View();
        }

        public IActionResult CadastroViagem(){
            return View();
        }

        public IActionResult CadastroUsuario(){
           return View();
         }

         public IActionResult Pacote(){
           return View();
         }
         
         public IActionResult Compra(){
           return View();
         }

         public IActionResult ExcluirUsuario(){
           return View();
         }
         public IActionResult AtualizarUsuario(){
           return View();
         }



        [HttpPost]
        public IActionResult Login(Usuario u){
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.Login(u);

            //Session  - Variaveis 
            if (usuario != null){
                HttpContext.Session.SetInt32("id",usuario.Id);
                HttpContext.Session.SetString("nome",usuario.Nome);
                HttpContext.Session.SetInt32("tipo",usuario.Tipo);
                   ViewBag.Mensagem ="Usuário logado com sucesso!";
                return Redirect("Conectado");
            } else{
                ViewBag.Mensagem ="Erro, usuário ou senha invalidos!";
                return View();
            }
        }

        [HttpPost]
        public IActionResult CadastroUsuario(Usuario Cuser){
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.Login(Cuser);
            ur.Insert(Cuser);
           return View();
         }

        [HttpPost]
        public IActionResult Compra(Compra compre){
            CompraRepository PR = new CompraRepository();
            PR.Insert(compre);
            return View();
         }

        [HttpPost]
        public IActionResult CadastroViagem(Pacote pc){
            PacoteRepository PR = new PacoteRepository();
            PR.Insert(pc);
            return View();
        }

        [HttpPost]
        public IActionResult Excluir(Usuario user){
            UsuarioRepository urep = new UsuarioRepository();
            urep.Excluir(user);
            return View();
        }

        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return View("Index");
        }
    }
}