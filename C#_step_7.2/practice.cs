using System;


namespace C__step_7._2
{


    public class Car
    {
        public string Color;
        public string Wheels;


    }
    class program
    {

        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Color = "Red";
            car1.Wheels = "4";

            Console.WriteLine("Car color is: " + car1.Color);



        }

    }
}


// inhertance 