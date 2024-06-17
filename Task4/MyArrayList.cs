namespace Task4;

public class MyArrayList
{
    private object[] items;
    private int count;

    public MyArrayList()
    {
        items = new object[4];
        count = 0;
    }
    
    // Властивість для отримання кількості елементів
    public int Count
    {
        get { return count; }
    }
    
    // Метод для додавання елемента
    public void Add(object item)
    {
        EnsureCapacity(count + 1);
        items[count++] = item;

    }
    
    // Метод для забезпечення достатньої ємності масиву
    public void EnsureCapacity(int min)
    {
        if (items.Length < min)
        {
            int newCapacity = items.Length == 0 ? 4 : items.Length * 2;
            if (newCapacity < min) newCapacity = min;
            Array.Resize(ref items, newCapacity);
        }
    }
    
    // Метод для вставки елемента на задану позицію
    public void Insert(int index, object item)
    {
        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        EnsureCapacity(count + 1);
        Array.Copy(items, index, items, index + 1,count - index);
        items[index] = item;
        count++;
    }

    // Метод для видалення елемента
    public void Remove(object item)
    {
        int index = IndexOf(item);
        if (index >= 0)
        {
            RemoveAt(index);
        }
    }
    
    // Метод для пошуку індексу елемента
    public int IndexOf(object item)
    {
        for (int i = 0; i < count; i++)
        {
            if (items[i].Equals(item))
            {
                return i;
            }
        }
        return -1;
    }

    // Метод для видалення елемента за індексом
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        count--;
        Array.Copy(items, index + 1, items, index, count - index);
        items[count] = null;
    }
    
    // Індексатор для отримання і встановлення елемента за індексом
    public object this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return items[index];
        }
        set
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            items[index] = value;
        }
    }
    
    // Метод для перевірки наявності елемента
    public bool Contains(object item)
    {
        return IndexOf(item) >= 0;
    }
}