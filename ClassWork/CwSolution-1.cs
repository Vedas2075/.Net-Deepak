class Greatest(int num1, int num2, int num3)
{
    if(num1 > num2)
    {
        if(num1 > num3)
        {
            Console.WriteLine("number 1 is greatest.");
        }
        else
        {
            Console.Writeline("Number 3 is the greated.");
        }
    }
    else if(num2 > num3)
    {
        Console.Writeline("Number 2 is the greatest.");
    } 
    else
    {
        Console.Writeline("Number 3 is the greatest.");
    }
}