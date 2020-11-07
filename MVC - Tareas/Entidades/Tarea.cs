using System;
using System.Collections.Generic;
using System.Text;

namespace MVC___Tareas.Entidades
{
    public class Tarea
    {
        private int iD;
        private string descripcion;
        private int duracion;

        public int ID { get => iD; set => iD = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public Tarea(int ID, string Descripcion, int Duracion)
        {
            this.ID = ID;
            this.Descripcion = Descripcion;
            this.Duracion = Duracion;
        }

        public string DatosTarea()
        {
            return this.ID + ";" + this.Descripcion + ";" + this.Duracion;
        }
    }
}
