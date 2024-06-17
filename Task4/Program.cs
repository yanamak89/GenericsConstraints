using Task4;

class Program
{
    static void Main(string[] args)
    {
        MyArrayList arrayList = new MyArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add(4);
        arrayList.Add(5);
        
        Console.WriteLine($"Array list contains + {arrayList.Count} elements.");
        
        arrayList.Insert(2,734);

        Console.WriteLine("Array list contains next values: ");
        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.Write(arrayList[i] + " ");
        }
        
        Console.WriteLine("\n" + new string('-', 30));
        Console.WriteLine($"Lets remove element from 1 position.");
        arrayList.RemoveAt(1);
        
        Console.WriteLine("Array list contains 10 elements? " + arrayList.Contains(10));
        Console.WriteLine("Array list contains 4 elements? " + arrayList.Contains(4));
        
        Console.WriteLine("After removing element from 1 possition. Array list contains next values: ");
        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.Write(arrayList[i] + " ");
        }
        Console.WriteLine("\n" + new string('-', 30));
        Console.WriteLine("Lets remove number 4 from array list.");
        arrayList.Remove(4);
        
        Console.WriteLine("After removing number 4. Array list contains next values: ");
        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.Write(arrayList[i] + " ");
        }
        Console.WriteLine("\n" + new string('-', 30));

    }
}