using System.Collections.Generic;

Console.WriteLine("Listas");

List<int> numeros = new List<int>() {
    2, 9, 9, 7, 9, 2
};

Console.WriteLine($"Cantidad de elementos en la lista: {numeros.Count}");

foreach (int numero in numeros) {
    Console.WriteLine($"Número: {numero}");
};

numeros.Add(4);
numeros.Add(5);

numeros.Clear();
Console.WriteLine($"Cantidad de elementos en la lista después de Clear: {numeros.Count}");