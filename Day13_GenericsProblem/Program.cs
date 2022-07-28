using Day13_GenericsProblem;
public class program
{
    public static void Main(string[] args)
    {
        //int[] intArray = { 34, 40, 89 };
        //double[] doubleArray = { 55.76, 67.02, 78.12 };
        //string[] stringArray = { "H","E", "L", "L", "O" };
        //genericmethod.toPrint<int>(intArray);
        //genericmethod.toPrint<double>(doubleArray);

        //genericmethod.toPrint<string>(stringArray);
        int maxInt = genericmethod.GetMaximum<int>(67, 29, 83);
        double maxFloat = genericmethod.GetMaximum<double>(56.7f, 96.4f, 75.7f);
        string maxString = genericmethod.GetMaximum<string>("Driver", "Pilot", "Engineer");

        Console.WriteLine(maxInt);
        Console.WriteLine(maxFloat);
        Console.WriteLine(maxString);

    }
}

