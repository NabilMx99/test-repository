using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var fileName = args.Length > 0 ? args[0] : "notes.txt";

        var path = Path.Combine("data", fileName);

        var contents = File.ReadAllText(path);

        Console.WriteLine(contents);
    }
}
