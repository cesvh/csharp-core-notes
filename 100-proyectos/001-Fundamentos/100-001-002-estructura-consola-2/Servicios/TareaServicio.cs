using _100_001_002_estructura_consola_2.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace _100_001_002_estructura_consola_2.Servicios
{
    internal class TareaServicio
    {
        private readonly List<Tarea> _tareas = new();

        public void Agregar(string descripcion)
        {
            var tarea = new Tarea
            {
                Id = _tareas.Count + 1,
                Descripcion = descripcion,
                Completada = false
            };

            _tareas.Add(tarea);
        }

        public void Listar()
        {
            if (_tareas.Count == 0)
            {
                Console.WriteLine("No existen tareas.");
                return;
            }

            foreach (var tarea in _tareas)
            {
                string estado = tarea.Completada ? "Completada" : "Pendiente";

                Console.WriteLine($"{tarea.Id}. {tarea.Descripcion} - {estado}");
            }
        }
    }
}
