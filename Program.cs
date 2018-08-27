using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {


            int n1;
            int n2;
            int s;  // s stand for solution
            Console.Write("calculator \n");
            Console.Write("enter the first value of the range ! ");
            n1 = Convert.ToInt32 (Console.ReadLine());   //read the user input  
            Console.Write("enter the last value of the range ! ");
            n2 = Convert.ToInt32 (Console.ReadLine());    //read the user input 


            s = (n2/2 * (n2 + n1));    // gauss addition formula 

            Console.Write("the sum of  " + n1 + " and " + n2 + " is : " + s);



            Console.ReadKey();
        }
    }
}
