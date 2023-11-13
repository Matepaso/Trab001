using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trab001.Models;
using Trab001.Repositorio;

namespace Trab001.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ContextoUsuario _contextUsuario;
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(ContextoUsuario context, IUsuarioRepositorio usuarioRepositorio)
        {
            _contextUsuario = context;
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Id, Nome, Email, Senha, ConfirmSenha, LembraMe")] Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                _contextUsuario.Add(usuario);
                await _contextUsuario.SaveChangesAsync();
                
                return RedirectToAction("Index", "Home");
            }
            return View(usuario);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login model, Usuario usuario)
        {
            try
            {
                usuario = _usuarioRepositorio.BuscarPorLogin(model.Email);
                if (usuario != null)
                {
                    if (usuario.validarSenha(model.Password))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    TempData["MensagemErro"] = $"Senha invalida";
                }
                TempData["MensagemErro"] = $"Email invalido";
                return RedirectToAction("Index");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Nao foi possivel logar: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

    }
}

