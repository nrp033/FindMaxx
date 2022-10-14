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

        internal float FindMaxFloat(float Value1, float Value2, float Value3)
        {

            if (Value1.CompareTo(Value2) > 0 && Value1.CompareTo(Value3) > 0)
            {
                return Value1;
            }
            if (Value2.CompareTo(Value1) > 0 && Value2.CompareTo(Value3) > 0)
            {
                return Value2;
            }
            if (Value3.CompareTo(Value1) > 0 && Value3.CompareTo(Value2) > 0)
            {
                return Value3;
            }
            return 0;
        }

        internal string FindMaxString(string s1, string s2, string s3)
        {
            if (s1.CompareTo(s2) > 0 && s1.CompareTo(s3) > 0)
            {
                return s1;
            }
            if (s2.CompareTo(s1) > 0 && s2.CompareTo(s3) > 0)
            {
                return s2;
            }
            if (s3.CompareTo(s1) > 0 && s3.CompareTo(s2) > 0)
            {
                return s3;
            }
            return default;
        }
    }
}
