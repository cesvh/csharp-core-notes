/*

Sobreescritura: Es la capacidad de una clase derivada de proporcionar una implementación específica de un método que ya está definido en su clase base. Para que un método pueda ser sobreescrito, debe ser declarado como virtual en la clase base y luego se puede usar la palabra clave override en la clase derivada para proporcionar una nueva implementación.

*/

Console.WriteLine("Sobre escritura");
Console.WriteLine();

A objA = new A();
Console.WriteLine(objA.Saludar());

B objB = new B();
Console.WriteLine(objB.Saludar());

class A
{
    // Si el método fuera public se podría heredar desde cualquier clase.
    // Si el método fuera private no se podría heredar desde ninguna clase.
    // Si el método fuera protected solo se podría heredar desde clases derivadas. Desde las clases hijos como la clase B.
    // con la palabra virtual se indica que el método puede ser sobreescrito por las clases derivadas.
    public virtual string Saludar()
    {
        return "Hola desde A";
    }
}

class B : A
{
    // Con la palabra override se indica que el método está sobreescribiendo un método virtual de la clase base.
    // Con la palabra base se puede acceder a la implementación del método en la clase base.
    public override string Saludar()
    {
        return base.Saludar() + " - Hola desde B";
    }
}