using Day13_GenericsProblem;
public class program
{
    public static void Main(string[] args)
    {
        int[] intArray = { 34, 40, 89, 80, 86, 34,};
        double[] doubleArray = { 55.76f, 67.02f, 78.12f,76.8f,45.3f, 64.8f};
        string[] stringArray = { "Driver", "Pilot", "Engineer", "Doctor", "IASOfficer","RevenueOfficer" };
        MaxNumberCheck<int> integer = new MaxNumberCheck<int>(intArray);
        MaxNumberCheck<double> doublenum = new MaxNumberCheck<double>(doubleArray);
        MaxNumberCheck<string> stringword = new MaxNumberCheck<string>(stringArray);

        integer.testMaximum();
        doublenum.testMaximum();
        stringword.testMaximum();
    }
}

