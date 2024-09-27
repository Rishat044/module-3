// Метод CalculateTotalPrice - вычисления итоговой суммы.
// Метод PrintOrderMessage - отвечает за вывод сообщения

public class OrderService
{
    public void CreateOrder(string productName, int quantity, double price)
    {
        double totalPrice = CalculateTotalPrice(quantity, price);
        PrintOrderMessage(productName, totalPrice, "created");
    }

    public void UpdateOrder(string productName, int quantity, double price)
    {
        double totalPrice = CalculateTotalPrice(quantity, price);
        PrintOrderMessage(productName, totalPrice, "updated");
    }

    private double CalculateTotalPrice(int quantity, double price)
    {
        return quantity * price;
    }

    private void PrintOrderMessage(string productName, double totalPrice, string action)
    {
        Console.WriteLine($"Order for {productName} {action}. Total: {totalPrice}");
    }
}
//--------------------------------------------------------------------------------------------------

//1. Создан базовый класс Vehicle, Car и Truck наследуются от Vehicle, метод Start и Stop использует this.GetType().Name
public class Vehicle
{
    public void Start()
    {
        Console.WriteLine($"{this.GetType().Name} is starting");
    }

    public void Stop()
    {
        Console.WriteLine($"{this.GetType().Name} is stopping");
    }
}

public class Car : Vehicle
{
}
public class Truck : Vehicle
{
}
//-------------------------------------------------------------------------------
// Удален интерфейс IShape, оставлены конкретные классы Circle и Square.
public class Circle
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Square
{
    private double _side;

    public Square(double side)
    {
        _side = side;
    }

    public double CalculateArea()
    {
        return _side * _side;
    }
}
//-----------------------------------------------------------------------------------

public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}