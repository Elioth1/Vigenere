using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
//using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vigenere.Models;

namespace vigenere.Controllers {

     public class VigenereController : Controller
    {
         static string Alfa = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        public IActionResult Index(){
            return View();
        }
        public IActionResult Encriptar(VigenereViewModel model)
        {
            ViewData["Mensaje"] = model.Mensaje;
            ViewData["Clave"] = model.Clave;
            return View(Cifrar(model.Mensaje, model.Clave));
        }

        public IActionResult Desencriptar()
        {
            ViewData["Message"] = "Desencriptar";

            return View();
        }

         static VigenereViewModel Cifrar(String Mensaje, string password)
        {
            
            return new VigenereViewModel();
        }



    }

}