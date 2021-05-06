using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Equipo5.Site.Models;
using Microsoft.Owin;
using Microsoft.Owin.Security;

namespace Equipo5.Site.Controllers
{

    [AllowAnonymous]
    public class AuthController : BaseController
    {
        
        [HttpGet]
        public ActionResult LogIn(string returnUrl)
        {
            var model = new LogInModel
            {
                ReturnUrl = @returnUrl
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult LogIn(LogInModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //TODO:
            //Esto se tiene que hacer con BD
            if (model.Email == "admin@equipo5.com" && model.Password == "adminlppa")
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, "admin@equipo5.com"),
                    new Claim(ClaimTypes.Email, "admin@equipo5.com"),
                    new Claim(ClaimTypes.Country, "Argentina"),
                };
                var identity = new ClaimsIdentity(claims, "ApplicationCookie");

                IOwinContext ctx = Request.GetOwinContext();
                IAuthenticationManager authManager = ctx.Authentication;

                authManager.SignIn(identity);
                return Redirect(GetRedirectUrl(model.ReturnUrl));

            }

            ModelState.AddModelError("", "El correo electronico o la contraseña no son validos");
            return View();
        }

        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }
    }
}