// У колекцію ArrayList, через виклик методу Add додайте елементи 
// структурного та посилального типу, 
// переберіть цю колекцію за допомогою циклу for. 
// З якою проблемою ви зіткнулися?

using System.Collections;
using Task6;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        // Додавання елементів різних типів
        arrayList.Add(new MyStruct(42));  //Структурний тип
        arrayList.Add(new MyClass("Hello")); //Референс тип
        arrayList.Add(100);                      //Iнший структурний тип
        arrayList.Add("World");                  //Iнший референс тип
        
        Console.WriteLine("Перебирання елементів за допомогою циклу for -> ");
        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.WriteLine(arrayList[i]);
        }
        
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Перебирання елементів за допомогою циклу foreach -> ");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        
        /*Console.WriteLine("Unhandled exception -> ");
        for (int i = 0; i < arrayList.Count; i++)
        {
            // Це може викликати InvalidCastException, якщо елемент не є типом MyStruct
            MyStruct myStruct = (MyStruct)arrayList[i]; 
            Console.WriteLine(myStruct.Number);
        }*/
        
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Вирішення проблеми -> ");
        for (int i = 0; i < arrayList.Count; i++)
        {
            if (arrayList[i] is MyStruct)
            {
                MyStruct myStruct = (MyStruct)arrayList[i];
                Console.WriteLine(myStruct.Number);
            }
            else if(arrayList[i] is MyClass)
            {
                MyClass myClass = (MyClass)arrayList[i];
                Console.WriteLine(myClass.Text);
            }
            else
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}