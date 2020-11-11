﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC___Tareas.Entidades;
using MVC___Tareas.Models;

namespace MVC___Tareas.Controllers
{
    public class TareasController : Controller
    {
        private readonly ILogger<TareasController> _logger;

        public TareasController(ILogger<TareasController> logger)
        {
            _logger = logger;
        }

        static Random aleat = new Random();
        static List<Tarea> tareasRealizadas = new List<Tarea>();
        static List<Tarea> listaTareas = new List<Tarea>();


        public IActionResult Index()
        {
            if (listaTareas.Count == 0)
            {
                listaTareas = Helper.GenerarListaTareasAleatorias(20);

                DeterminarEstadoTarea(listaTareas);
            }

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
                listaTareas.Add(nTarea);
            }
            else
            {
                mensaje = "Error al momento de crear la tarea";
            }

            return Content(mensaje);
        }

        public IActionResult ModificarTarea()
        {
            return View(listaTareas);
        }

        [HttpPost]
        public IActionResult ModificarEstadoTarea(int id)
        {
            string mensaje = "";
            if (id > 0 && id <= listaTareas.Count + tareasRealizadas.Count)
            {
                mensaje = "Su tarea fue modificada";
                Tarea tareaMod = new Tarea();
                tareaMod = Helper.BusquedaPorId(listaTareas, id);
                tareasRealizadas.Add(tareaMod);

                RemoverTareaPorId(listaTareas, id);
            }
            else
            {
                mensaje = "Error al momento de modificar la tarea";
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
                    listaTareas.RemoveAt(i);
                    i--;
                }
                
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

        public void RemoverTareaPorId(List<Tarea> listaTareas, int id)
        {
            for (int i = 0; i < listaTareas.Count; i++)
            {
                if (listaTareas[i].ID == id)
                {
                    listaTareas.RemoveAt(i);
                }
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
