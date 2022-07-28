using Day13_GenericsProblem;
public class program
{
    public static void Main(string[] args)
    {
        
        int maxInt = new GenericClass<int>(15, 42, 53).GetMaximum();
        double maxFloat = new GenericClass<double>(11.6f, 23.6f, 43.4f).GetMaximum();
        string maxString = new GenericClass<string>("Driver", "Pilot", "Engineer").GetMaximum();

        Console.WriteLine(maxInt);
        Console.WriteLine(maxFloat);
        Console.WriteLine(maxString);

    }
}

