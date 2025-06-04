using System;
namespace automobiles;

class Program
{
    static void Main(string[] args)
    {
        Motorcycle cb250 = new Motorcycle(250, 20000, 2024, 250);
        Car gol = new Car(1050, 25000.00, 2001, 76);
        
        RentalLogger cb250Logger = new RentalLogger(cb250);
        RentalLogger golLogger = new RentalLogger(gol);
        
        cb250.ShowInfo();
        gol.ShowInfo();

        cb250.RentVehicle();
        gol.RentVehicle();
        
        Console.WriteLine("\n--------------------\n");
        
        gol.ReturnVehicle();
        cb250.ReturnVehicle();
    }
}
