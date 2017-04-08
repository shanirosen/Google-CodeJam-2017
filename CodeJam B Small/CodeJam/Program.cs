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
            
            string file = "B-small-attempt0";
            string inputFile = "../../../"+file+".in";
            string outputFile = "../../../"+file+".out";
            using (StreamReader reader = new StreamReader(inputFile))
            {
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    long numberOfCases = long.Parse(reader.ReadLine());

                    for (long i = 1; i <= numberOfCases; i++)
                    {
                        string N = reader.ReadLine();

                        if (long.Parse(N) < 10)
                        {
                            writer.WriteLine("Case #" + i + ": " + N);
                            continue;
                        }

                        long Ncopy = long.Parse(N);
                        long copy = 0;

                        for (long k = Ncopy; k >= 10; k--)
                        {
                            if (Ncopy < 10)
                                break;

                            copy = k;
                            Ncopy = k;


                            for (long j = 0; j < N.Length - 1; j++)
                            {
                                if (Ncopy % 10 >= (Ncopy / 10) % 10)
                                    Ncopy /= 10;
                                
                                if (Ncopy < 10)
                                    break;
                            }

                        }

                        writer.WriteLine("Case #" + i +": " + copy);

                    }
                }
                   
            }
            
            

           


        }

        /*public static void Tidy()
        {


            string N = "1958473";
            if (long.Parse(N) < 10)
            {
                Console.WriteLine("Last Num Is: " + N);
            }


            //"556"
            //

            long Ncopy = long.Parse(N);
            long copy = 0;

            for (long k = Ncopy; k >= 10; k--)
            {
                if (Ncopy < 10)
                    break;

                copy = k;
                Ncopy = k;


                for (long j = 0; j < N.Length - 1; j++)
                {

                    if (Ncopy % 10 >= (Ncopy / 10) % 10)
                    {

                        Ncopy /= 10;
                    }
                    if (Ncopy < 10)
                    {
                        break;
                    }
                }

            }

            Console.WriteLine("Last Num: " + copy);


        }*/
    }
}
