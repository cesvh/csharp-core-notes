using System;
using System.Collections.Generic;
using System.Text;

namespace _100_001_002_estructura_consola_2.Modelos
{
    internal class Tarea
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public bool Completada { get; set; }
    }
}
