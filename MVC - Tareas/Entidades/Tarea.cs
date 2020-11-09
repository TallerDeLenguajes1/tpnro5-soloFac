using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MVC___Tareas.Entidades
{
    public class Tarea
    {
        private int iD;
        private string descripcion;
        private int duracion;
        

        public int ID { get => iD; set => iD = value; }
        [Required(ErrorMessage = "Tiene que definir una descripcion para la tarea")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        [Required(ErrorMessage = "La tarea necesita tener una duracion")]
        public int Duracion { get => duracion; set => duracion = value; }

        public Tarea()
        {
                
        }

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
