namespace OOP_Seminar1;

public abstract class Product(string name, int price)
{
        public string Name { get; set; } = name;
        public int Price { get; set; } = price;
        protected string? Type { get; init; }

        public override string ToString() => $"Тип: {Type ?? "Неизвестен"}, Наименование: {Name}, цена: {Price}";
}