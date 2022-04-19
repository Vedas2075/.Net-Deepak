class Methods
{
    // 1. No return value, no parameter
    void PrintHello()
    {
        Console.WriteLine("Hello Bouy!!");
    }

    // 2. No return value but single parameter
    void PrintHello(string name)
    {
        Console.WriteLine("Hello, " + name ); //Concatenation
        Console.WriteLine($"Hello, {name}" ); //Dynamic Variable use
    }

    // 3. return value and two parameter
    string FormatName(string firstName, string lastName)
    {
        return $"{lastName}, {firstName}";
    }

    // 4. Expression Syntax
    string FormatName2(string firstName, string lastName) => $"{lastName}, {firstName}" ;
    // Method Expression Syntax
    bool IsEven(short number) => number % 2 == 0;

    // 5. Variable number of arguments-->  internal vs public access modifier
    public double Sum(params double[] numbers) => numbers.Sum();    

}
