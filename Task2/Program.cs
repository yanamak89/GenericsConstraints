using Task2;

class Program
{
    static void Main(string[] args)
    {
        CarCollection carCollection = new CarCollection();
        
        carCollection.AddCar("Toyota Corolla", 2010);
        carCollection.AddCar("Honda Civic", 2015);
        carCollection.AddCar("Ford Fiesta", 2011);
        
        Console.WriteLine("Total cars added: " + carCollection.Count);

        for (int i = 0; i < carCollection.Count; i++)
        {
            Console.WriteLine($"Car {i + 1}: {carCollection[i]}");
        }
        
        carCollection.Clear();
        
        Console.WriteLine("All cars cleared.Total cars now: " + carCollection.Count);
    }
}