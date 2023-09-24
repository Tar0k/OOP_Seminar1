// Создать наследника реализованного класса ГорячийНапиток с дополнительным полем int температура.
// Создать класс ГорячихНапитковАвтомат реализующий интерфейс ТорговыйАвтомат и
// реализовать перегруженный метод getProduct(int name, int volume, int temperature),
// выдающий продукт соответствующий имени, объёму и температуре

// В main проинициализировать несколько ГорячихНапитков и ГорячихНапитковАвтомат и воспроизвести логику, заложенную в программе
// Всё вышеуказанное создать согласно принципам ООП, пройденным на семинаре

using OOP_Seminar1;


Console.WriteLine("===================LESSON==========================");
var waterVendingMachine = new WaterVendingMachine();
var tempList = new List<Product>
{
    new BottleOfWater("Волжанка", 57, 2),
    new BottleOfWater("Мвятой источник", 45, 1),
    new BottleOfWater("Aqua mineral", 87, 1),
    new BottleOfWater("Bon aqua", 80, 3)
};
waterVendingMachine.InitProducts(tempList);

waterVendingMachine.PrintProducts();
Console.WriteLine("===================Get by name==========================");
Console.WriteLine(waterVendingMachine.GetProduct("Волжанка"));
Console.WriteLine("===================Get by name and volume==========================");
Console.WriteLine(waterVendingMachine.GetProduct("Bon aqua", 3));

Console.WriteLine("===================HOMEWORK==========================");
var hotBeverageVendingMachine = new HotBeverageVendingMachine();

tempList = new List<Product>
{
    new HotBeverage("TESS", 57, 1, 70),
    new HotBeverage("LIPTON", 97, 4, 50),
    new HotBeverage("TESS", 40, 3, 40),
    new HotBeverage("НУРИ", 92, 2, 80)
};
hotBeverageVendingMachine.InitProducts(tempList);
hotBeverageVendingMachine.PrintProducts();
Console.WriteLine("===================Get by name, volume and temperature======================");
Console.WriteLine(hotBeverageVendingMachine.GetProduct("LIPTON", 4, 50));

