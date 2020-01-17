using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Data_Types
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            //uints i.e. unsigned-integers cannot hold negative values. Can hold the same number of values as an int, but an int splits them up between negative and positive values. 32 bits
            uint someUInteger = 5;

            Console.WriteLine(someUInteger);

            uint maxUint = uint.MaxValue;

            //equal numbers here. 
            Console.WriteLine(maxUint);
            Console.WriteLine(Math.Pow(2, 32));

            //the byte datatype can hold 8 bits, 2 raised to the 8th power (256). 8 bits
            byte maxByte = byte.MaxValue;

            Console.WriteLine(maxByte);

            //like byte but can hold negative numbers
            sbyte maxSByte = sbyte.MaxValue;

            Console.WriteLine(maxSByte);

            //hold a huge value. 64 bits
            long maxLong = long.MaxValue;

            //9.22 Quintillion
            Console.WriteLine(maxLong);

            //ulong meaning unsigned-long. It will give only positive values. 

        }
    }
}
