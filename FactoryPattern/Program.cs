namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?");
            int.TryParse(Console.ReadLine(), out int wheelCount);

            IVehicle vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
           }
    }
}
