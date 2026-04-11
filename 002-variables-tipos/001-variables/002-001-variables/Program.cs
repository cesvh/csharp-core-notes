using static System.Console;

WriteLine("Variables");
WriteLine("");

// int es un tipo de dato que representa números enteros, es decir, sin decimales. En C#, el tipo int tiene un rango de -2,147,483,648 a 2,147,483,647.
int numero = 2;
// string es un tipo de dato que representa una secuencia de caracteres, es decir, texto. En C#, el tipo string puede contener cualquier cantidad de caracteres, incluyendo letras, números y símbolos.
string texto = "César";
// bool es un tipo de dato que representa un valor booleano, es decir, verdadero o falso. En C#, el tipo bool solo puede tener dos valores: true (verdadero) o false (falso).
bool esVerdadero = true;
// float es un tipo de dato que representa números decimales de precisión simple, es decir, con una precisión de aproximadamente 7 dígitos. En C#, el tipo float tiene un rango de ±1.5 x 10^−45 a ±3.4 x 10^38, por ejemplo, 3.14f. El sufijo 'f' se utiliza para indicar que el número es un float.
// Si no se incluye el sufijo, el número se tratará como un double por defecto.
float numeroDecimal = 3.14f;
// double es un tipo de dato que representa números decimales de precisión doble, es decir, con una precisión de aproximadamente 15-16 dígitos. En C#, el tipo double tiene un rango de ±5.0 × 10^−324 a ±1.7 × 10^308, por ejemplo, 3.14. El sufijo 'd' se puede utilizar para indicar que el número es un double, pero no es obligatorio ya que el número se tratará como un double por defecto.
double numeroDecimal2 = 3.14;

WriteLine($"numero: {numero}");
WriteLine($"texto: {texto}");
WriteLine($"esVerdadero: {esVerdadero}");
WriteLine($"numeroDecimal: {numeroDecimal}");
WriteLine($"numeroDecimal2: {numeroDecimal2}");
