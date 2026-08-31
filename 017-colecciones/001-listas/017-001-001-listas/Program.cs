using System.Collections.Generic;

Console.WriteLine("Listas");

// List<T> es una clase genérica que representa una lista de objetos que se pueden acceder por índice. Es parte del espacio de nombres System.Collections.Generic.
List<int> numeros = new List<int>() {
    2, 9, 9, 7, 9, 2
};

Console.WriteLine($"Cantidad de elementos en la lista: {numeros.Count}");

foreach (int numero in numeros) {
    Console.WriteLine($"Número: {numero}");
};

numeros.Add(4);// Add agrega un elemento al final de la lista
numeros.Add(5);

numeros.Clear();// Clear elimina todos los elementos de la lista
Console.WriteLine($"Cantidad de elementos en la lista después de Clear: {numeros.Count}");