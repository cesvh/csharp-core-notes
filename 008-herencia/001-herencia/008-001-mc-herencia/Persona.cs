namespace _008_001_mc_herencia
{
    // namespace : es un contenedor lógico para organizar clases y otros tipos de datos relacionados.
    // Ayuda a evitar conflictos de nombres y a estructurar el código de manera más clara.

    // internal class: es un modificador de acceso que indica que la clase solo es accesible dentro del mismo ensamblado (proyecto). No puede ser accedida desde otros proyectos o ensamblados.
    internal class Persona
    {
        private int _anio;
        private string _nombre;

        public Persona(int anio, string nombre)
        {
            _anio = anio;
            _nombre = nombre;
        }

        public int Anio
        {
            get { return _anio; }
            set
            {
                if (value < 1901) { value = 1901; }
                _anio = value;
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrEmpty(value)) { value = "Sin nombre"; }
                _nombre = value;
            }
        }

        public string obtenerInformacion() 
        {
            return $"Nombre: {Nombre}, Año de nacimiento: {Anio}";
        }
    }
}