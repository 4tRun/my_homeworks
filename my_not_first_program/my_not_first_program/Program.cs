class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        string output = $"Hello World and {name}!";
        Console.WriteLine(output);
    }
}
