
namespace Task1;


public  class Car : IVehicle
{
    public void Drive()
    {
         System.Console.WriteLine("Driving");
    }

    public void Drive(int a)
    {
        throw new NotImplementedException();
    }

    public bool Refuel(int a)
    {
        a++;
        return true;
    }

    internal void Refuel(object a)
    {
        throw new NotImplementedException();
    }
}
