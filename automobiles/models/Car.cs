
public class Car : Automobile{

    int _horse_power;

    public Car(double weight, double price, int year, int horse_power) : base(weight, price, year){
        _horse_power = horse_power;
    }
    public override void ShowInfo(){
        base.ShowInfo();
        Console.WriteLine($"Esse carro tem {_horse_power} cavalos\n");
    }

}