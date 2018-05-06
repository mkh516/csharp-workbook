using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Car car1 = new Car("blue", 3);
            Car car2 = new Car("red", 2);
            Car car3 = new Car("black", 1);
            Console.WriteLine(car1.Color);
            Console.WriteLine(car1.Size);
            Console.WriteLine(car1.Rate);

            Garage garage1 = new Garage(3);

            garage1.ParkCar(car1, 0);
            garage1.ParkCar(car2, 1);
            garage1.ParkCar(car3, 2);
            Console.WriteLine(garage1.Cars);
        }
    }

    class Car 
    {
       public Car(string color, int size)
       {
           Color = color;
           Size = size;
           //Coupons = {"5Percent","10Percent"};
           Rate = 3f;
       }

       public string Color { get; private set; }

       public int Size { get; private set; }

       public float Rate { get; private set; }
    }

    class Garage
    {
        private Car[] cars;
        public Garage(int specifiedSize)
        {
            Size = specifiedSize;
            cars = new Car[specifiedSize];  //why do you need "this."
        }

        public int Size { get; private set; }

        public string Cars
        {
            get
            {
                return $"Car in spot 0 is {cars[0].Color} and car in spot 1 is {cars[1].Color}";
            }
        }
        
        public void ParkCar(Car car, int spot)
        {
            cars[spot] = car;
        }

        public void UnparkCar(Car car, int spot)
        {
            cars[spot] = null;
        }

    }

}
