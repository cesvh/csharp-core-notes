namespace _008_001_mc_herencia
{
    internal class Usuario : Persona
    {
        private string _usuario;

        public Usuario(int anio, string nombre, string usuario) : base(anio, nombre)
        {
            _usuario = usuario;
        }

        public string obtenerDatos()
        {
            return obtenerInformacion() + $", Usuario: {_usuario}";
        }
    }
}
