namespace Polymorfism
{
    using System;

    public class Vehicle
    {
        // Virtuell metod som kan "skrivas över" i underklasser
        public virtual void Talk() => Console.WriteLine("Generellt fordon.");
    }

    public class Car : Vehicle
    {
        // Skriver över den virtuella metoden för Car-klassen
        public override void Talk() => Console.WriteLine("Detta är en bil.");
    }

    public class Truck : Vehicle
    {
        // Skriver över den virtuella metoden för Truck-klassen
        public override void Talk() => Console.WriteLine("Detta är en lastbil.");
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Polymorfism: Vehicle-referenser som pekar på specifika objekt
            Vehicle car = new Car();
            Vehicle truck = new Truck();

            car.Talk();    // Använder Car:s version av Talk-metoden
            truck.Talk();  // Använder Truck:s version av Talk-metoden
        }
    }
}



