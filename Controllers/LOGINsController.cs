
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using WMVCLivros.Models;

namespace WMVCLivros.Controllers
{
    public class LOGINsController : Controller
    {
        // GET: LOGINs
        private readonly Contexto _context;

        public LOGINsController(Contexto context)
        {
            _context = context;
        }
        public IActionResult Login(String login, String Senha)
        {
            if (login == "nilton" && Senha == "1234")
            {
                return RedirectToAction("Index", "Home");
            }
            return View();

        }


    }
}
