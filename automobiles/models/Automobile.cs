public delegate void RentalStatusHandler(DateTime timestamp);

public abstract class Automobile : AutomobileInterface
{
    public int _year {get;set;}
    public double _weight {get;set;}
    public double _price {get;set;}
    
    public event RentalStatusHandler? OnRent;
    public event RentalStatusHandler? OnReturn;

    public Automobile(double weight, double price, int year){
        _weight = weight;
        _price = price;
        _year = year;
    }

    public virtual void ShowInfo(){
        Console.WriteLine($"Dados do automóvel:\nPeso: {_weight}\nPreço: {_price}\nAno:{_year}\n");
    }

     public virtual void RentVehicle()
    {
        Console.WriteLine($"Alugando o automóvel ano {_year}...");
        OnRent?.Invoke(DateTime.Now);
    }

    public virtual void ReturnVehicle()
    {
        Console.WriteLine($"Devolvendo o automóvel ano {_year}...");
        OnReturn?.Invoke(DateTime.Now);
    }
}