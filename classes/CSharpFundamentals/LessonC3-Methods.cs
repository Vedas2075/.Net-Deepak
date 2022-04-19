class Methods
{
    void PrintHello()
    {
        Console.WriteLine("Hello Bouy!!");
    }

    void PrintHello(string name)
    {
        Console.WriteLine("Hello, " + name ); //Concatenation
        Console.WriteLine($"Hello, {name}" ); //Dynamic Variable use
    }

    string FormatName(string firstNamme, string lastName)
    {
        return $"{lastName}, {firstName}";
    }

    //

}