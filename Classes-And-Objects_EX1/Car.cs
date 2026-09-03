using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects_EX1
{
    public class Car
    {
        private string register, color;
        private float speed;

        public void SetCar(string register, string color)
        {
            this.register = register;
            this.color = color;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public void ShowCar()
        {
            Console.WriteLine($"[CAR INFO] \nregister: {register} \ncolor: {color} \nspeed: {speed}");
        }

        public string AskRegister()
        {
            Console.WriteLine("Enter register for car: ");
            return Console.ReadLine();
        }

        public string AskColor()
        {
            Console.WriteLine("Enter color for car: ");
            return Console.ReadLine();
        }

        public void Accelerate(float amount)
        {
            if (speed + amount > 120)
            {
                BreakALot();
                return;
            }

            speed += amount;
        }

        public void BreakALittle()
        {
            float newSpeed = speed - 5;

            if (newSpeed < 0)
            {
                speed = 0;
                return;
            }
            
            speed -= 5;
           
        }

        public void BreakALot()
        {
            float newSpeed = speed - 10;

            if (newSpeed < 0)
            {
                speed = 0;
                return;
            }

            speed -= 10;
        }

        public void Stop()
        {
            speed = 0;
        }
    }
}
