class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("Apple", 1);
        dictionary.Add("Banana", 2);
        dictionary.Add("Cherry", 3);
        
        Console.WriteLine("Total pairs: " + dictionary.Count);
        Console.WriteLine("Value for 'Apple': " + dictionary["Apple"]);
        Console.WriteLine("Value for 'Banana': " + dictionary["Banana"]);
        Console.WriteLine("Value for 'Cherry': " + dictionary["Cherry"]);


        try
        {
            Console.WriteLine("Key for 'Durian': " + dictionary["Durian"]);
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}