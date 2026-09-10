using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_And_Overriding_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercises 1-4

            Point myPoint = new Point(5, 2);

            Point[] pointsArray = new Point[4];
            pointsArray[0] = new Point();

            for (int i = 1; i < pointsArray.Length; i++)
            {
                Point point = AskCoordinates();
                pointsArray[i] = point;
            }

            for (int i = 0; i < pointsArray.Length; i++)
            {
                Console.Write($"Point {i + 1}: ");
                pointsArray[i].ShowPoint();
            }

            #endregion

            #region Exercises 5 & 6

            Grade[] gradesArray = new Grade[10];
            int gradesCount = 0;
            int gradesSum = 0;

            bool isRunning = true;

            while (isRunning)
            {
                gradesArray[gradesCount] = AskGradeInfo();
                gradesSum += gradesArray[gradesCount].GetGrade();
                gradesCount++;

                Console.WriteLine("Press Enter to continue or q to quit");

                if (Console.ReadLine().ToLower() == "q" || gradesCount == gradesArray.Length)
                    isRunning = false;
            }

            Console.WriteLine($"Number of grades {gradesCount}, average: {(double)gradesSum / gradesCount}");

            #endregion
        }

        private static Point AskCoordinates()
        {
            Console.WriteLine("Give x coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            return new Point(x, y);
        }

        private static Grade AskGradeInfo()
        {
            Console.WriteLine("Enter student id: ");
            int studentID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Give grade from range 1-5: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            return new Grade(studentID, grade);
        }
    }
}
