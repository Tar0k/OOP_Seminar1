using System.Runtime.CompilerServices;

namespace OOP_Seminar1;

public class BottleOfWater : Beverage
{
    public BottleOfWater(string name, int price, int volume) : base(name, price, volume)
    {
        Type = "Бутылка воды";
    }
}