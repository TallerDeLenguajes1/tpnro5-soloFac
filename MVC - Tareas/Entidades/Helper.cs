using System;
using System.Collections.Generic;
using System.Text;

namespace MVC___Tareas.Entidades
{
    public static class Helper
    {
        static int ID = 0;
        static Random aleat = new Random();
        static string[] descripciones = { "logistica", "envios locales", "limpieza automovilistica", "listado de productos" };

        public static List<Tarea> GenerarListaTareasAleatorias(int cantTareas)
        {
            List<Tarea> listaTareas = new List<Tarea>();
            for (int i = 0; i < cantTareas; i++)
            {
                ID += 1;
                string Descripcion = descripciones[aleat.Next(4)];
                int Duracion = aleat.Next(10, 101);
                Tarea NTarea = new Tarea(ID, Descripcion, Duracion);

                listaTareas.Add(NTarea);
            }
            return listaTareas;
        }

        public static Tarea BusquedaPorId(List<Tarea> listaTareas, int id)
        {
            foreach (Tarea tarea in listaTareas)
            {
                if (tarea.ID == id)
                {
                    return tarea;
                }
            }
            return null;
        }

        public static Tarea BusquedaPorPalabra(List<Tarea> listaTareas, string palabra)
        {
            foreach (Tarea tarea in listaTareas)
            {
                if (tarea.Descripcion.Contains(palabra))
                {
                    return tarea;
                }
            }
            return null;
        }

        public static void ListarTareas(List<Tarea> listaTareas)
        {
            foreach (Tarea tarea in listaTareas)
            {
                MostrarTarea(tarea);
            }
        }

        public static void MostrarTarea(Tarea tarea)
        {
            Console.WriteLine("\n ---------------- \n");
            Console.WriteLine("ID: " + tarea.ID);
            Console.WriteLine("Descripcion: " + tarea.Descripcion);
            Console.WriteLine("Duracion: " + tarea.Duracion);
        }
    }
}
