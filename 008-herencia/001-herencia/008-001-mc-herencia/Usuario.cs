// La herencia es un concepto fundamental en la programación orientada a objetos que permite crear una nueva clase (clase derivada o subclase) a partir de una clase existente (clase base o superclase). La clase derivada hereda los miembros (propiedades, métodos, etc.) de la clase base, lo que permite reutilizar código y establecer una relación jerárquica entre las clases.
// Se usa los dos puntos (:) para indicar que una clase hereda de otra clase, seguido del nombre de la clase base.
namespace _008_001_mc_herencia
{
    internal class Usuario : Persona
    {
        // Se usa guion bajo para indicar que es un campo privado, es una convención común en C# para diferenciar los campos privados de las variables locales o parámetros.
        private string _usuario;

        // La sintaxis para llamar al constructor de la clase base desde el constructor de la clase derivada es utilizando la palabra clave base seguida de los argumentos que se deben pasar al constructor de la clase base.
        // No es necesario usar this para acceder a los campos heredados de la clase base, ya que estos campos son accesibles directamente en la clase derivada. Sin embargo, se puede usar this para referirse a los campos de la clase derivada si es necesario, pero no es necesario ya que no hay ambigüedad con los campos heredados de la clase base.
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
