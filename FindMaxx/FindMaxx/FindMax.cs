using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxx
{
    internal class FindMax
    {
        public int FindMaxInteger(int FirstNum, int SecondNum, int ThirdNum)
        {

            if (FirstNum.CompareTo(SecondNum) > 0 && FirstNum.CompareTo(ThirdNum) > 0)
            {
                return FirstNum;
            }
            if (SecondNum.CompareTo(FirstNum) > 0 && SecondNum.CompareTo(ThirdNum) > 0)
            {
                return SecondNum;
            }
            if (ThirdNum.CompareTo(FirstNum) > 0 && ThirdNum.CompareTo(SecondNum) > 0)
            {
                return ThirdNum;
            }
            return 0;

        }
    }
}
