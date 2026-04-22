Console.WriteLine("Sobre escritura");
Console.WriteLine();

A objA = new A();
Console.WriteLine(objA.Saludar());

B objB = new B();
Console.WriteLine(objB.Saludar());

class A 
{
    public virtual string Saludar()
    {
        return "Hola desde A";
    }
}

class B : A
{
    public override string Saludar()
    {
        return base.Saludar() + " - Hola desde B";
    }
}