using System.Collections.Generic;
public class Collection
{
    // Simple array
    byte[] ages = {23, 45, 67, 12, 20, 21, 43, 54, 76, 90 };

    // List
    List<string> names = new() {"deep", "hellor"};
    
    // Stack 
    Stack<decimal> marks = new(){};

    // Queue
    Queue<short> tokens = new();

    // Dictionary
    Dictionary<string, double> nameMarks = new()
    {
        ["Deepak"] = 90,
        ["Deep"] = 80,
        ["Jeep"] = 70
    }; 
    void Test()
    {
        names.Add("Deepak");
        names.Remove("Deepak");
        var x = names.Contains("Ram");  // Returns true or false

        marks.Push(45.67m); // m for decimal
        marks.Peek();
        marks.Push(43.1m);
        marks.Peek();
        marks.Pop();
        marks.Peek();

        tokens.Enqueue(13);
        tokens.Peek();
        tokens.Enqueue(15);
        tokens.Peek();
        tokens.Dequeue();

        nameMarks.Add("Heep", 12);

        Print<int>(45);
    }

    void Print<T>(T parameter)      // T for type(anything)
    {
        Console.WriteLine(parameter);
    }
}