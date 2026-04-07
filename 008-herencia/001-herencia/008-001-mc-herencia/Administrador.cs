namespace _008_001_mc_herencia
{
    internal class Administrador : Persona
    {
        private string _departamento;

        public Administrador(int anio, string nombre, string departamento) : base(anio, nombre)
        {
            _departamento = departamento;
        }

        public string obtenerDatos() 
        {
            return obtenerInformacion() + $", Departamento: {_departamento}";
        }
    }
}
