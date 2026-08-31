Console.WriteLine("Listas - Métodos");

List<int> numbers = new List<int>()
{
    4,3,5,19
};

Show(numbers);

// Insert
// El método Insert inserta un elemento en la lista en la posición especificada. En este caso, se inserta el número 6 en la posición 1 de la lista (índice 1).
numbers.Insert(1, 6);

Show(numbers);

// Contains
// El método Contains verifica si un elemento específico existe en la lista. En este caso, se verifica si el número 19 está presente en la lista. Si el número 19 se encuentra en la lista, se imprime "existe"; de lo contrario, se imprime "no existe".
if (numbers.Contains(19))
    Console.WriteLine("existe");
else
    Console.WriteLine("no existe");

// IndexOf
// El método IndexOf devuelve el índice de la primera aparición de un elemento específico en la lista. En este caso, se busca el número 19 en la lista y se imprime su posición (índice). Si el número 19 no se encuentra en la lista, se devuelve -1. Luego, se busca el número 100, que no está presente en la lista, por lo que se imprimirá -1.
int pos = numbers.IndexOf(19);
Console.WriteLine(pos);
pos = numbers.IndexOf(100);
Console.WriteLine(pos);

// Sort
// El método Sort ordena los elementos de la lista en orden ascendente. En este caso, se ordenan los números en la lista.
numbers.Sort();
Show(numbers);

// Add Range
// El método AddRange agrega los elementos de una colección al final de la lista. En este caso, se crea una nueva lista llamada numbers2 con los números 300, 200 y 400. Luego, se utiliza el método AddRange para agregar todos los elementos de numbers2 al final de la lista numbers.
var numbers2 = new List<int>()
            {
                300,200,400
            };
numbers.AddRange(numbers2);

Show(numbers);
static void Show(List<int> numbers)
{
    Console.WriteLine("-- Numeros --");
    foreach (var n in numbers)
    {
        Console.WriteLine(n);
    }
}
