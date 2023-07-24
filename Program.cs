using System;
namespace InputfromUser
{

    class Input
    {
        static void Main(string[] args)
        {
            double num;
            double circum;
            double pie = 3.142;
            //MAIN STARTS
            Console.WriteLine("Input Radius:");
            object on = Console.ReadLine();
            num = Convert.ToInt32(on);
            //MAIN ENDS
            circum = num * pie;

            Console.WriteLine("Circumference is {0}", circum);

        }
    }
}