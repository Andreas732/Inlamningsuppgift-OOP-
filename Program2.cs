namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar ett nytt objekt av klassen Car (car1) och sätter dess egenskaper
            Car car1 = new Car();

            car1.brand = "Honda";
            car1.modell = "2001";
            car1.type = "Combi";

            // Skapar ett nytt objekt av klassen Car (car2) och sätter dess egenskaper
            Car car2 = new Car();

            car2.brand = "Bmw";
            car2.modell = "1993";
            car2.type = "SUV";

            // Skapar ett nytt objekt av klassen Car (car3) och sätter dess egenskaper
            Car car3 = new Car();

            car3.brand = "Porsche";
            car3.modell = "2023";
            car3.type = "Sedan";

            // Anropar Talk-Metoden  för car1 som skriver ut information om bilen
            car1.Talk();

            // Anropar Talk-Metoden  för car2 som skriver ut information om bilen
            car2.Talk();

            // Anropar Talk-Metoden  för car3 som skriver ut information om bilen
            car3.Talk();

            // Väntar på att användaren trycker på en tangent innan konsolfönstret stängs
            Console.ReadLine();
        }

        // Definierar klassen Car som innehåller 3 publika fält: brand, modell samt type
        public class Car
        {
            public string brand;
            public string modell;
            public string type;

            public void Talk()
            {
                Console.WriteLine($"{brand} är namnet på bilen, {modell} är årsmodellen på bilen, {type} är formen på bilen");
            }



        }
    }
}
