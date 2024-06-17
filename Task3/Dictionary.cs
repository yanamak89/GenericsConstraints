using System;
using System.Collections.Generic;
namespace Task3;

//Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно
// екземпляру класу Dictionary
// із простору імен System.Collections.Generic.
// Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати
// метод додавання пар елементів,
// індексатор для отримання значення елемента за вказаним індексом і
// властивість тільки для читання для отримання загальної кількості пар елементів.

public class Dictionary<TKey, TValue>
{
    private List<TKey> keys = new List<TKey>();
    private List<TValue> values = new List<TValue>();

    // Метод додавання пар елементів
    public void Add(TKey key, TValue value)
    {
        if (!keys.Contains(key))
        {
            keys.Add(key);
            values.Add(value);
        }
        else
        {
            throw new ArgumentException("An element with the same key already exists.");
        }

    }
    
    // Індексатор для отримання значення за ключем
    public TValue this[TKey key]
    {
        get
        {
            int index = keys.IndexOf(key);
            if (index != -1)
            {
                return values[index];
            }

            throw new KeyNotFoundException("The key was not found.");
        }
    }

    // Властивість тільки для читання для отримання загальної кількості пар елементів
    public int Count
    {
        get {
            return keys.Count;
        }
    }
}


