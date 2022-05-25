using System.IO;

public class FileIO
{
    public void ReadFileFromDisk(string path)
    {
        string fileText = File.ReadAllText(path);        
        Console.WriteLine(fileText);
    }

    public void CreateFileToDisk()
    {
        // Verbatim character @
        string filePath = @"C:\Users\I82287\OneDrive - Cotiviti\Documents\vedas1.txt";
        File.WriteAllText(filePath, "This is second file");
        ReadFileFromDisk(filePath);
    }
}