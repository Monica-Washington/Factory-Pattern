namespace FactoryPattern;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("You are driving a car, truck or SUV!");
    }
}