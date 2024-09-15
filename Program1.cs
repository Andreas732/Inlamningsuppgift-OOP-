namespace Inlämningsuppgift_3__Abstraktion_
{
    public abstract class Vehicle
    {
        // Abstrakt metod som måste implementeras av underklasser
        public abstract void Talk();
    }

    public class Car : Vehicle
    {
        // Implementerar den abstrakta metoden för Car
        public override void Talk() => Console.WriteLine("Bilens information.");
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Skapar ett Car-objekt och anropar den abstrakta metoden via Vehicle
            Vehicle car = new Car();
            car.Talk();  // Anropar Car:s implementation av Talk-metoden
        }
    }
}
