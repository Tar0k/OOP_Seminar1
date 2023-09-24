using System.Runtime.InteropServices;

namespace OOP_Seminar1;

public abstract class Beverage(string name, int price, int volume) : Product(name, price)
{
    public int Volume { get; set; } = volume;
}