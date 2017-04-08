using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace CodeJam
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string file = "B-large";
            string inputFile = "../../../" + file + ".in";
            string outputFile = "../../../" + file + ".out";
            using (StreamReader reader = new StreamReader(inputFile))
            {
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    long numberOfCases = long.Parse(reader.ReadLine());

                    for (long i = 1; i <= numberOfCases; i++)
                    {
                        long Number = long.Parse(reader.ReadLine());
                        long copyN = Number;
                        string close_Tidy = ClosestTidy(Number);
                        writer.WriteLine("Case #" + i + ": " + close_Tidy);

                    }
                }
            }
        }

        public static string ClosestTidy(long Ncopy)
        {

            char[] NcharArr = Ncopy.ToString().ToCharArray();
            long[] digits = Array.ConvertAll(NcharArr, c => (long)Char.GetNumericValue(c));

            while (!IsTidy(Convert.ToInt64(ArrayToString(digits))))
            {
                for (int i = digits.Length - 1; i > 0; i--)
                {
                    
                    digits[i] = 9;

                    if (digits[i - 1] == 0 && i > 0)
                    {
                        digits[i - 1] = 9;
                    }

                    else if(digits[0]>=1)
                    {
                        digits[i - 1] -= 1;
                    }
                    else
                    {
                        digits[i - 1] = 1;
                    }
                   
                    if (IsTidy(Convert.ToInt64(ArrayToString(digits))))
                        break;
                }
            }
            return ArrayToString(digits);
        }

        public static bool IsTidy(long N)
        {
            if (N < 10)
                return true;
            if (N % 10 < (N / 10) % 10)
                return false;
            return IsTidy(N / 10);
        }

        public static string ArrayToString(long[] arr)
        {
            string finale = "";
            for (int i = 0; i < arr.Length; i++)
            {
                finale += arr[i];
            }

            return finale;
        }
    }
}
