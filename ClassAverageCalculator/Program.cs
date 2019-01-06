using System;

namespace ClassAverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Math = 0, English = 0, Biology = 0, Physics = 0, Chemistry = 0, ComputerS = 0, FurtherMath = 0, BusinessStudies = 0, sum, average;

            Console.WriteLine("Student Grade Calculator");

            Console.Write("Please enter Student's name: ");
            string studentname = Console.ReadLine();

            Console.WriteLine("PLEASE ENTER SCORES FOR THE FOLLOWING SUBJECTS");

            Console.Write("Mathematics: ");
            Math = decimal.Parse(Console.ReadLine());

            Console.Write("English Language: ");
            English = decimal.Parse(Console.ReadLine());

            Console.Write("Biology: ");
            Biology = decimal.Parse(Console.ReadLine());

            Console.Write("Physics: ");
            Physics = decimal.Parse(Console.ReadLine());

            Console.Write("Chemistry: ");
            Chemistry = decimal.Parse(Console.ReadLine());

            Console.Write("Computer Science: ");
            ComputerS = decimal.Parse(Console.ReadLine());

            Console.Write("Further Math: ");
            FurtherMath = decimal.Parse(Console.ReadLine());

            Console.Write("Business Studies: ");
            BusinessStudies = decimal.Parse(Console.ReadLine());

            sum = Math + English + Biology + Physics + Chemistry + ComputerS + FurtherMath + BusinessStudies;
            average = sum / 8.00m;

            if (average >= 70 && average <= 100)
            {
                Console.WriteLine("The Student's Grade is: A with an average score of {0}", average);
            }
            else if (average >= 60 && average <= 69)
            {
                Console.WriteLine("The Student's Grade is: B with an average score of {0}", average);
            }
            else if (average >= 50 && average <= 59)
            {
                Console.WriteLine("The Student's Grade is: C with an average score of {0}", average);
            }
            else if (average >= 40 && average <= 49)
            {
                Console.WriteLine("The Student's Grade is: D with an average score of {0}", average);
            }
            else if (average >= 30 && average <= 39)
            {
                Console.WriteLine("The Student's Grade is: E with an average score of {0}", average);
            }
            else
            {
                Console.WriteLine("The Student's Grade is: F with an average score of {0}", average);
            }

            Console.ReadLine();
        }
    }
}
