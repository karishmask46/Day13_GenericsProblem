using Day13_GenericsProblem;
public class program
{
    public static void Main(string[] args)
    {


        int[] intArray = { 34, 40, 89, 80, 86, 34,};
        double[] doubleArray = { 55.76f, 67.02f, 78.12f,76.8f,45.3f, 64.8f};
        string[] stringArray = { "Driver", "Pilot", "Engineer", "Doctor", "IASOfficer","RevenueOfficer" };
        Sortmethod.FindMax<int>(intArray);
        Sortmethod.FindMax<double>(doubleArray);
        Sortmethod.FindMax<string>(stringArray);

    }
}

