# Eligibility-for-Engineering-Admission
## Aim:
To write a C# program to check whether the student is eligibile for the engineering admission

## Algorithm:
### Step1: 
Get the maths, chemistry and physics marks from the user using ReadLine().
### Step2: 
Calculate the sum of all three subjects and check whether the sum is greater than and equal to 180

### Step3:
Calculate the sum of physics and maths and check the condition

### Step4:
Calculate the sum of all three subjects and maths-physics total.

### Step5:
Check for the given criteria for eligibility using if-else statements.

### Step6:
Display whether the person is eligible for admission or not based on the given criteria.

## Program:
```
NAME:VAISHNAVI S
REGISTER NO :22009040
```
```
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
```
## Output:
![Screenshot 2024-02-22 103629](https://github.com/Vaishnavi-saravanan/Eligibility-for-Engineering-Admission/assets/118541897/dbf58ccd-d98d-42ad-9153-c7169cd232e3)

## Result:
Thus the above C# program to check the eligibility of engineering admission is successfully executed

