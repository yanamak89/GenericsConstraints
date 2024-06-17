namespace Task2;
/*
 * Реалізуйте у найпростішому наближенні можливість використання екземпляра
   для створення парку машин. 
   Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати 
   метод додавання машин з назвою машини і року її випуску,
   індексатор для отримання значення елемента за вказаним індексом і 
   властивість тільки для читання для отримання загальної кількості елементів. 
   Створіть спосіб видалення всіх машин автопарку.
 */

public class CarCollection
{
    private List<Car> cars = new List<Car>();

    public void AddCar(string name, int year)
    {
        cars.Add(new Car(name, year));
    }

    public Car this[int index]
    {
        get
        {
            if (index < 0 || index >= cars.Count)
            {
                throw new IndexOutOfRangeException("Invalid Index");
            }

            return cars[index];
        }
    }

    public int Count
    {
        get { return cars.Count; }
    }

    public void Clear()
    {
        cars.Clear();
    }
}