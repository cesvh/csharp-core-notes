Console.WriteLine("Propiedades");

var usuario = new Usuario("cesar", -12000);

Console.WriteLine($"usuario.Nombre: {usuario.Nombre}");
Console.WriteLine($"usuario.AnioNacimiento: {usuario.AnioNacimiento}");

usuario.Nombre = "César";
usuario.AnioNacimiento = 1991;

Console.WriteLine($"usuario.Nombre: {usuario.Nombre}");
Console.WriteLine($"usuario.AnioNacimiento: {usuario.AnioNacimiento}");

class Usuario {
    private string _nombre;
    private int _anioNacimiento;

    public Usuario(string nombre, int anioNacimiento)
    {
        _nombre = nombre;
        _anioNacimiento = anioNacimiento;
    }

    public string Nombre
    {
        get
        {
            return _nombre;
        }
        set
        {
            if (string.IsNullOrEmpty(value)) {
                value = "Sin nombre";
            }
            _nombre = value;
        }
    }

    public int AnioNacimiento
    {
        get
        {
            return _anioNacimiento;
        }
        set
        {
            if (value < 1901)
            {
                value = 1901;
            }
            _anioNacimiento = value;
        }
    }
}
