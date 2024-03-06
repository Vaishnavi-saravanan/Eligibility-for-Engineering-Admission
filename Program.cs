using System;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            int maths, physics, chemistry;
            Console.WriteLine("Welcome to Engineering Admission Eligibility Checker");

            Console.Write("Enter Math marks: ");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Physics marks: ");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry marks: ");
            chemistry = Convert.ToInt32(Console.ReadLine());

            int totalMarks = maths + physics + chemistry;

            if (maths >= 75 && physics >= 65 && chemistry >= 60)
            {
                if (totalMarks >= 180)
                {
                    Console.WriteLine("Congratulations! You are eligible for admission.");

                }
                else
                {
                    Console.WriteLine("Sorry, you are not eligible for admission.");

                }
            }
        }
    }
}