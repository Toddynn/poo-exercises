public class RentalLogger
{
    public RentalLogger(Automobile vehicle)
    {
        vehicle.OnRent += LogRent;
        vehicle.OnReturn += LogReturn;
    }

    private void LogRent(DateTime timestamp)
    {
        Console.WriteLine($"Veículo alugado em: {timestamp}");
    }

    private void LogReturn(DateTime timestamp)
    {
        Console.WriteLine($"Veículo devolvido em: {timestamp}");
    }
}