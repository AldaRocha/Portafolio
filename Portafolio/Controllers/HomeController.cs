using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers{
    public class HomeController : Controller{    //HomeController hereda la clase Controller
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IServicioEmail servicioEmail;

        public HomeController(IRepositorioProyectos repositorioProyectos, IServicioEmail servicioEmail){
            this.repositorioProyectos = repositorioProyectos;
            this.servicioEmail = servicioEmail;
        }

        public IActionResult Index(){                   //Pide el archivo html y regresa
            /*var persona = new Persona
            {
                nombre = "Francisco Rocha",
                edad=21
            };*/
            var proyectos=repositorioProyectos.obtenerProyectos().Take(3).ToList();
            var modelo=new homeIndexViewModel()
            {
                proyectos=proyectos
            };
            return View(/*persona*/modelo);                   //Una vista
        }

        public IActionResult Privacy(){ //Si en la primera peticion de pantalla seleccionamos privacy 
            return View();              //Este va a ejecutar esta peticion de html privacy y regresa la vista
        }

        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.obtenerProyectos();
            return View(proyectos);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            await servicioEmail.Enviar(contactoViewModel);
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration=0, Location=ResponseCacheLocation.None, NoStore=true)]
        public IActionResult Error(){
            return View(new ErrorViewModel{RequestId=Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}