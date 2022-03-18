// See https://aka.ms/new-console-template for more information

using System;
class MainClass
{
    public static void Main(string[] args)
    {

        bool cycle = true;
        do
        {



            Console.WriteLine("How many people will be eating? ");
            int input = Int32.Parse(Console.ReadLine());
            //double num1 = double.Parse(input);
            double totalSlicesOfBread = input * 2;
            double totalSpoonsOfPb = input * 2;
            double totalSpoonsOfJelly = input * 4;

            double totalLoaves = Math.Ceiling(totalSlicesOfBread / 28);
            double totalJarsOfPb = Math.Ceiling(totalSpoonsOfPb / 32);
            double totalJarsOfJelly = Math.Ceiling(totalSpoonsOfJelly / 48);


            Console.WriteLine("The total number of bread slices is " + totalSlicesOfBread);
            Console.WriteLine("The total number of Peanut Butter tablespoons is " + totalSpoonsOfPb);
            Console.WriteLine("The total number of jelly teaspoons is  " + totalSpoonsOfJelly);

            Console.WriteLine("The total number of loaves is " + totalLoaves);
            Console.WriteLine("The total number of jars of Peanut Butter is " + totalJarsOfPb);
            Console.WriteLine("The total number of jars of Jelly is " + totalJarsOfJelly);

            Console.WriteLine("Would you like to start over? ");
            string input2 = Console.ReadLine();

            if (input2 != "y" && input2 != "yes")
            {
                cycle = false;
            }

        } while (cycle == true);

        Console.WriteLine("Goodbye!");
    }
}    
