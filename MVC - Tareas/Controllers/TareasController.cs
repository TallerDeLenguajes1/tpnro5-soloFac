using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC___Tareas.Entidades;

namespace MVC___Tareas.Controllers
{
    public class TareasController : Controller
    {
        static Random aleat = new Random();
        static List<Tarea> tareasRealizadas = new List<Tarea>();
        static List<Tarea> listaTareas = new List<Tarea>();

        public IActionResult Index()
        {
            listaTareas = Helper.GenerarListaTareasAleatorias(20);

            DeterminarEstadoTarea(listaTareas);

            return View(listaTareas);
        }

        public IActionResult TareasRealizadas()
        {
            return View(tareasRealizadas);
        }

        public IActionResult AltaTarea()
        {
            return View(new Tarea());
        }

        [HttpPost]
        public IActionResult CrearTarea(Tarea nTarea)
        {
            string mensaje = "";
            if (ModelState.IsValid)
            {
                mensaje = "Su tarea fue creada";
            }
            else
            {
                mensaje = "Error al momento de crear la tarea";
            }

            return Content(mensaje);
        }

        public void DeterminarEstadoTarea(List<Tarea> listaTareas)
        {
            for (int i = 0; i < listaTareas.Count; i++)
            {
                if (TareaFueRealizada())
                {
                    tareasRealizadas.Add(listaTareas[i]);
                }
                listaTareas.RemoveAt(i);
            }
        }

        public bool TareaFueRealizada()
        {
            if (aleat.Next(2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
