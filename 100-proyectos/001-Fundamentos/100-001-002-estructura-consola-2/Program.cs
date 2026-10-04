using _100_001_002_estructura_consola_2.Servicios;

Console.WriteLine("Hello, World!");
Console.WriteLine();

var tareaService = new TareaServicio();

bool continuar = true;

while (continuar)
{
    Console.WriteLine();
    Console.WriteLine("=== GESTOR DE TAREAS ===");
    Console.WriteLine("1. Agregar tarea");
    Console.WriteLine("2. Listar tareas");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción: ");

    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Descripción: ");

            string? descripcion = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                Console.WriteLine("La descripción es obligatoria.");
                break;
            }

            tareaService.Agregar(descripcion);

            Console.WriteLine("Tarea agregada correctamente.");
            break;

        case "2":
            tareaService.Listar();
            break;

        case "3":
            continuar = false;
            Console.WriteLine("Aplicación finalizada.");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}