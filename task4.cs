public abstract class Vehicle
{
    public abstract string StartEngine();
}

public class Car : Vehicle
{
    public override string StartEngine()
    {
        return "Car engine started";
    }
}

public class Bicycle : Vehicle
{
    public override string StartEngine()
    {
        return "Pedaling the bicycle";
    }
}

// გამოყენება:
Car car = new Car();
Console.WriteLine(car.StartEngine());

Bicycle bicycle = new Bicycle();
Console.WriteLine(bicycle.StartEngine());
