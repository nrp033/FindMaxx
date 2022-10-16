using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxx
{
    internal class FindMax<T> where T:IComparable
    {
        private T First;
        private T Second;
        private T Third;

        public FindMax(T a,T b,T c)
        {
            First = a;
            Second = b;
            Third = c;
        }
        public T FindMaxShow() 
        { 

            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                return First;
            }
            if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                return Second;
            }
            if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {
                return Third;
            }
            return default;

        }

       
    }
}
