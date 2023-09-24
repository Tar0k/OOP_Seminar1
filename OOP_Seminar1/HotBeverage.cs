namespace OOP_Seminar1;

public class HotBeverage : Beverage
{
    public HotBeverage(string name, int price, int volume, int temperature) : base(name, price, volume)
    {
        Type = "Горячий напиток";
        Temperature = temperature;
    }
    
    public int Temperature { get; }
}