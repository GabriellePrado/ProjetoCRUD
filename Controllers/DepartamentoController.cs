using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste1.Models.Departamento;

namespace Teste1.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> listaDepartamento = new List<Departamento>();
            listaDepartamento.Add(new Departamento (1, "Ana"));
            listaDepartamento.Add(new Departamento (2 , "Jucimar"));
            listaDepartamento.Add(new Departamento(3, "Bob"));

            return View(listaDepartamento);
        }
    }
}
