using Microsoft.AspNetCore.Mvc;
using CRUDCORE.Datos;
using CRUDCORE.Models;
namespace CRUDCORE.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _ContactoDatos = new ContactoDatos();

        //LA VISTA MOSTRARA UNA LISTA DE CONTACTOS
        public IActionResult Listar()
        {
            var oLista = _ContactoDatos.Listar();
            return View(oLista);
        }
        
        public IActionResult Guardar()
        {
            //solo DEVOLVERA LA VISTA , muestra el formulario 
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
                return View();
            //METODO QUE RECIBE EL OBJETO PARA GUARDARLO EN LA BD
            var respuesta = _ContactoDatos.Guardar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
            return View();
        }

        public IActionResult Editar(int IdContacto)
        {
            //solo DEVOLVERA LA VISTA , muestra el formulario 
            var ocontacto = _ContactoDatos.Obtener(IdContacto);
            return View(ocontacto);
        }
        [HttpPost]
        //post=guardar
        public IActionResult Editar(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
                return View();
            //METODO QUE RECIBE EL OBJETO PARA GUARDARLO EN LA BD
            var respuesta = _ContactoDatos.Editar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Eliminar(int IdContacto)
        {
            //solo DEVOLVERA LA VISTA , muestra el formulario 
            var ocontacto = _ContactoDatos.Obtener(IdContacto);
            return View(ocontacto);
        }
        [HttpPost]
        //post=guardar
        public IActionResult Eliminar(ContactoModel oContacto)
        {
         
            //METODO QUE RECIBE EL OBJETO PARA GUARDARLO EN LA BD
            var respuesta = _ContactoDatos.Eliminar(oContacto.IdContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
    }
}
