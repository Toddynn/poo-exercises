public class Motorcycle : Automobile{
    
    int _cylinder_capacity;

    public Motorcycle(double weight, double price, int year, int cylinder_capacity) : base(weight, price, year){
        _cylinder_capacity = cylinder_capacity;
    }

     public override void ShowInfo(){
        base.ShowInfo();
        Console.WriteLine($"Essa moto tem {_cylinder_capacity} cilindradas\n");
    }

}