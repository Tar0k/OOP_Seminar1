// Создать наследника реализованного класса ГорячийНапиток с дополнительным полем int температура.
// Создать класс ГорячихНапитковАвтомат реализующий интерфейс ТорговыйАвтомат и
// реализовать перегруженный метод getProduct(int name, int volume, int temperature),
// выдающий продукт соответствующий имени, объёму и температуре

// В main проинициализировать несколько ГорячихНапитков и ГорячихНапитковАвтомат и воспроизвести логику, заложенную в программе
// Всё вышеуказанное создать согласно принципам ООП, пройденным на семинаре

using OOP_Seminar1;


Console.WriteLine("===================LESSON==========================");
var waterVendingMachine = new WaterVendingMachine();
waterVendingMachine.Add(new BottleOfWater("Волжанка", 57, 2));
waterVendingMachine.Add(new BottleOfWater("Мвятой источник", 45, 1));
waterVendingMachine.Add(new BottleOfWater("Aqua mineral", 87, 1));
waterVendingMachine.Add(new BottleOfWater("Bon aqua", 80, 3));

waterVendingMachine.PrintProducts();
Console.WriteLine("===================Get by name==========================");
Console.WriteLine(waterVendingMachine.GetProduct("Волжанка"));
Console.WriteLine("===================Get by name and volume==========================");
Console.WriteLine(waterVendingMachine.GetProduct("Bon aqua", 3));

Console.WriteLine("===================HOMEWORK==========================");
var hotBeverageVendingMachine = new HotBeverageVendingMachine();
hotBeverageVendingMachine.Add(new HotBeverage("TESS", 57, 1, 70));
hotBeverageVendingMachine.Add(new HotBeverage("LIPTON", 97, 4, 50));
hotBeverageVendingMachine.Add(new HotBeverage("TESS", 40, 3, 40));
hotBeverageVendingMachine.Add(new HotBeverage("НУРИ", 92, 2, 80));
hotBeverageVendingMachine.PrintProducts();
Console.WriteLine("===================Get by name, volume and temperature======================");
Console.WriteLine(hotBeverageVendingMachine.GetProduct("LIPTON", 4, 50));

