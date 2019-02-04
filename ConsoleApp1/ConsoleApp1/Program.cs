using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                long num1 = long.Parse(space[0]);
                if (num1 % 2 != 0)
                {
                    long num2 = (long)Math.Pow(2, num1);
                    
                    if(num2> 10)
                    {
                        long res1 =0;
                        while (num2 != 0)
                        {
                            res1 = num2 % 10;
                            num2 /= 10;
                        }
                        Console.WriteLine((-1) * res1);
                    }
                    else
                    {
                        Console.WriteLine((-1) * (long)Math.Pow(2, num1));
                    }
                }
                else
                {
                    long num = (long)Math.Pow(2, num1);
                    if (num > 10)
                    {
                        long res1 = 0;
                            while (num != 0)
                            {
                                res1 = num % 10;
                                num /= 10;
                            }
                            
                        Console.WriteLine($"+{res1}");
                    }
                    else
                    {
                        long sum = (long)Math.Sign(+1) * (long)Math.Pow(2, num1);
                        Console.WriteLine($"+{sum}");
                    }
                }
            }
        }
    }
}