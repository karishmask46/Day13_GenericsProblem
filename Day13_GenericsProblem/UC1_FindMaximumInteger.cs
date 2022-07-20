using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericsProblem
{
   
        class UC1_FindMaximumInteger
        {
            public int Getmaximum(int first_number, int second_number, int third_number)
            {
                if (first_number.CompareTo(second_number) > 0 && first_number.CompareTo(third_number) > 0)
                {
                    return first_number;
                }
                if (second_number.CompareTo(first_number) > 0 && second_number.CompareTo(third_number) > 0)
                {
                    return second_number;
                }
                if (third_number.CompareTo(first_number) > 0 && third_number.CompareTo(second_number) > 0)
                {
                    return third_number;
                }
                throw new Exception("firstNumber,secondNumber and thirdNumber are same");


            }
        public double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }



    }

}




