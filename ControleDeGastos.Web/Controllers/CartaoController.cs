using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    public class CartaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}