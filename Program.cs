using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!!");
            Console.WriteLine("\nEnter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("How tall are you? (CM)");
            
            float tall = float.Parse(Console.ReadLine());
            float t_in_meter = 0.0f;
            t_in_meter = tall / 100;
            Console.WriteLine("Wight? (KG)");
            
            float w = float.Parse(Console.ReadLine());
            float bmi = w / ((float)Math.Pow(t_in_meter, 2));
            string res;
            
            if (bmi<18.1)
            {
                res = "you are underweight";

            }
            else if(bmi >= 18.1 && bmi < 23.1)
            {
                res = "you have normal weight";

            }
            else if (bmi >= 23.1 && bmi < 28.1)
            {
                res = "you are overweight";

            }
            else
            {
                res = "you are obese";

            }

            Console.WriteLine("Nice to meet you " + name + "\nYour age is " + age + "\nYou are " + t_in_meter + " meter tall \n" + res +".") ;
            Console.WriteLine("\nThank you!!!");
            Console.ReadLine();
        }
    }
}
