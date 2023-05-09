using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumbers
{
    public class DataType
    {
        ulong array;

        public string Array
        {
            get;
            set;
        }

        public string INV(string value)
        {
            string valueINV = "";
            for (int i = 0; i < value.Length; i++)
            {
                valueINV += (~UInt64.Parse(value[i].ToString(), NumberStyles.AllowHexSpecifier)).ToString();
            }
            return valueINV;
        }

        public string XOR(string value, string value2)
        {
            string valueXOR = "";
            for (int i = 0; i < value.Length; i++)
            {
                valueXOR += (UInt64.Parse(value[i].ToString(), NumberStyles.AllowHexSpecifier) ^ UInt64.Parse(value2[i].ToString(), NumberStyles.AllowHexSpecifier)).ToString();
            }
            return valueXOR;
        }

        public string AND(string value, string value2)
        {
            string valueXOR = "";
            for (int i = 0; i < value.Length; i++)
            {
                valueXOR += (UInt64.Parse(value[i].ToString(), NumberStyles.AllowHexSpecifier) & UInt64.Parse(value2[i].ToString(), NumberStyles.AllowHexSpecifier)).ToString();
            }
            return valueXOR;
        }

        public string ShiftR(string value, int n)
        {
            string valueINV = "";
            for (int i = 0; i < value.Length; i++)
            {
                valueINV += (UInt64.Parse(value[i].ToString(), NumberStyles.AllowHexSpecifier) >> n).ToString();
            }
            return valueINV;
        }

        public string ShiftL(string value, int n)
        {
            string valueINV = "";
            for (int i = 0; i < value.Length; i++)
            {
                valueINV += (UInt64.Parse(value[i].ToString(), NumberStyles.AllowHexSpecifier) << n).ToString();
            }
            return valueINV;
        }
        public string ADD(string value, string value2)
        {
            string valueXOR = "";
            for (int i = 0; i < value.Length; i++)
            {
                valueXOR += (UInt64.Parse(value[i].ToString(), NumberStyles.AllowHexSpecifier) + UInt64.Parse(value2[i].ToString(), NumberStyles.AllowHexSpecifier)).ToString();
            }
            return valueXOR;
        }
    };
}
