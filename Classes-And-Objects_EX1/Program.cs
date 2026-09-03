using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.SetName("Eemil", "Korkka");
            employee.SetSalary(3000);

            Console.WriteLine("[EMPLOYEE DETAILS]");
            Console.WriteLine(employee.GetName());
            employee.PrintSalary();
            Console.WriteLine(employee.CalcTax(30));

            Console.WriteLine();

            Point point = new Point();
            point.SetPoint(1, 5);
            point.ShowPoint();

            Car car = new Car();
            car.SetCar("ABC-123", "Red");
            car.Accelerate(50);
            float speed = car.GetSpeed();
            car.BreakALittle();
            car.BreakALot();
            car.ShowCar();

            Console.WriteLine();

            Car firstCar = new Car();
            Car secondCar = new Car();

            firstCar.SetSpeed(0);
            secondCar.SetSpeed(0);

            string firstRegister = firstCar.AskRegister();
            string firstColor = firstCar.AskColor();
            firstCar.SetCar(firstRegister, firstColor);

            string secondRegister = secondCar.AskRegister();
            string secondColor = secondCar.AskColor();
            secondCar.SetCar(secondRegister, secondColor);

            bool isRunning = true;

            while (isRunning)
            {
                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "b":
                        firstCar.Accelerate(5);
                        Console.WriteLine("Car 1 accelerated by 5");
                        break;

                    case "c":
                        secondCar.Accelerate(5);
                        Console.WriteLine("Car 2 accelerated by 5");
                        break;

                    case "d":
                        firstCar.BreakALittle();
                        Console.WriteLine("Car 1 speed decreased by 5");
                        break;

                    case "e":
                        firstCar.BreakALot();
                        Console.WriteLine("Car 1 speed decreased by 10");
                        break;

                    case "f":
                        secondCar.BreakALittle();
                        Console.WriteLine("Car 2 speed decreased by 5");
                        break;

                    case "g":
                        secondCar.BreakALot();
                        Console.WriteLine("Car 2 speed decreased by 10");
                        break;

                    case "q":
                        float firstCarSpeed = firstCar.GetSpeed();
                        float secondCarSpeed = secondCar.GetSpeed();

                        Console.WriteLine($"Car 1 speed: {firstCarSpeed}, Car 2 speed: {secondCarSpeed}");
                        
                        if (firstCarSpeed == secondCarSpeed)
                        {
                            Console.WriteLine("Car speeds match!");
                        }

                        break;

                    case "x":
                        firstCar.Stop();
                        secondCar.Stop();

                        Console.WriteLine("Both cars stopped!");
                        isRunning = false;
                        break;
                }
            } 
        }
    }
}
