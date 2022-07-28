using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericsProblem
{
    public class MaxNumberCheck<T>
    {
        public T[] array;
        public MaxNumberCheck(T[] array)
        {
            this.array = array;
        }
        public T[] Sort(T[] inputArray)
        {
            Array.Sort(inputArray);
            return inputArray;
        }
        public T PrintMax()
        {
            var sorted_values = Sort(this.array);
            return sorted_values[sorted_values.Length - 1];
        }
        public void testMaximum()
        {
            var max = PrintMax();
            Console.WriteLine(max);
        }
    }
}

       