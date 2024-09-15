namespace Inlämningsuppgift_3__Inkapsling_
{
    public class Car
    {
        // Privat fält som skyddas från direkt åtkomst
        private string _brand;

        // Publik egenskap för att komma åt och ändra det privata fältet
        public string Brand
        {
            get { return _brand; }  // Getter för att läsa värdet
            set { _brand = value; }  // Setter för att sätta värdet
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Honda";  // Sätter värdet genom egenskapen
            Console.WriteLine(car.Brand); // Hämtar värdet genom egenskapen, skriver "Honda"
        }
    }
}
