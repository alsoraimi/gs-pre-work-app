using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pre_work_grand_circ
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;               
            int revNum = 0;       // named revNum for reversed number
            Console.WriteLine("please enter any number higher than 0: ");
            num = int.Parse(Console.ReadLine());  // had to convert from int to string
            while (num != 0)
            {
                revNum = revNum * 10;   
                revNum = revNum + num % 10; // added reversed number multiplied by 10 plus the remainder of original num and 10
                num = num / 10;  // since this is a int there will be no decimles, which will in turn give you the reversed number
            }

            Console.WriteLine("Your reversed outcome is {0}! " , revNum);
            Console.ReadLine();




        }
    }
}
