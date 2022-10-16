using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxx
{
    internal class FindMax<T> where T:IComparable
    {
        public T[] Value;

        public FindMax(params T[] value)
        {
           this.Value = value;
        }
        public T[] Sort(T[] values)//Method to sort Array Element
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue( T[] values)
        {
            var sorted_Values = Sort(values);
            return sorted_Values[^1];
        }
        public T Maxmethod()
        {
            var max = MaxValue(this.Value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.Value);
            Console.WriteLine("Maximum Value is :  " + max);
        }

    }
}
