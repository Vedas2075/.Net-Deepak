// Write a C# program to check if entered alphabet is vowel or not?
class Vowel
{
    void vowel()
    {
        Console.WriteLine("Enter a letter: ");
        string letter = Console.ReadLine();
        // char l = char.ToLower(letter);
        switch(letter)
        {
            case 'a':
            Console.WriteLine($"'{letter}' is a vowel letter.");
            break;

            case 'e':
            Console.WriteLine($"'{letter}' is a vowel letter.");
            break;

            case 'i':
            Console.WriteLine($"'{letter}' is a vowel letter.");
            break;

            case 'o':
            Console.WriteLine($"'{letter}' is a vowel letter.");
            break;

            case 'u':
            Console.WriteLine($"'{letter}' is a vowel letter.");
            break;   

            default:
            Console.WriteLine($"'{letter}' is not a vowel letter.");
            break;
        }
    }
}