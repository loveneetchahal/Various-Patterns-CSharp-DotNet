﻿using DecoratorPattern.Component;
using DecoratorPattern.ConcreteDecorators;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new SmallCar();
            Console.WriteLine($"Price of car {car.GetName()} : " + car.CarPrice());

            var car1 = new Sunroof(car);
            Console.WriteLine($"Price of car {car1.GetName()} : " + car1.CarPrice());

            var car2 = new AdvanceMusic(car);
            Console.WriteLine($"Price of car {car2.GetName()} : " + car2.CarPrice());
        }

        public class SmallCar : Car
        {
            public override int CarPrice() => 10000;

            public override string GetName() => "Alto Lxi";
        }
    }
}
