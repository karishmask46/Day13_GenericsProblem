﻿using Day13_GenericsProblem;
public class program
{
    public static void Main(string[] args)
    {
        //Checking the maximum integer
        Console.WriteLine("Enter the first number");
        int first_number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int second_number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third number");
        int third_number = Convert.ToInt32(Console.ReadLine());
        UC1_FindMaximumInteger findmax = new UC1_FindMaximumInteger();
        if (findmax.Getmaximum(first_number, second_number, third_number) != 0)
            Console.WriteLine("{0} is Maximum out of {1} ,{2}, {3}", findmax.Getmaximum(first_number, second_number, third_number), first_number, second_number, third_number);
        //checking maximum float number
        Console.WriteLine("Enter the first number");
        Double firstValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        Double secondValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the third number");
        Double thirdValue = Convert.ToDouble(Console.ReadLine());
        UC1_FindMaximumInteger maxFloat = new UC1_FindMaximumInteger();
        if (maxFloat.MaximumFloatNumber(firstValue, secondValue, thirdValue) != 0)
            Console.WriteLine("{0} is Maximum out of {1} ,{2}, {3}", maxFloat.MaximumFloatNumber(firstValue, secondValue, thirdValue), firstValue, secondValue, thirdValue);
       //checking maximum string number
        Console.WriteLine("Enter the first word");
        string firstString = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter the second word");
        string secondString = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter the third word");
        String thirdString= Convert.ToString(Console.ReadLine());
        UC1_FindMaximumInteger maxString = new UC1_FindMaximumInteger();
        if (maxString.MaximumStringNumber(firstString, secondString, thirdString) != null)
            Console.WriteLine("{0} is Maximum out of {1} ,{2}, {3}", maxFloat.MaximumStringNumber(firstString, secondString, thirdString), firstString, secondString, thirdString);
            
    }
}

