// La sobrecarga de métodos es una característica de la programación orientada a objetos que permite definir múltiples métodos con el mismo nombre pero con diferentes parámetros. Esto permite que un método pueda realizar diferentes tareas dependiendo de los argumentos que se le pasen. En el ejemplo proporcionado, la clase Math tiene tres métodos Sum con el mismo nombre pero con diferentes tipos y números de parámetros: uno que suma dos enteros, otro que suma dos cadenas de texto convirtiéndolas a enteros, y otro que suma un arreglo de enteros. La sobrecarga de métodos mejora la legibilidad del código y permite una mayor flexibilidad al llamar a los métodos con diferentes tipos de datos o cantidades de argumentos.

Console.WriteLine("Sobre carga");
Console.WriteLine();

Math math = new Math();

int[] numbers = new int[] { 1, 2, 5 };

Console.WriteLine(math.Sum(1, 2));
Console.WriteLine(math.Sum("1", "2"));
Console.WriteLine(math.Sum(numbers));

public class Math
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Sum(string a, string b)
    {
        return int.Parse(a) + int.Parse(b);
    }

    public int Sum(int[] numbers)
    {
        int result = 0;
        int i = 0;

        while (i < numbers.Length)
        {
            result += numbers[i];
            i++;
        }
        return result;
    }
}
