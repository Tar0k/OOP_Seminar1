namespace OOP_Seminar1;

public abstract class Product(string name, int price)
{
        public string Name { get; } = name;
        private int Price { get; } = price;
        protected string? Type { get; init; }

        public override string ToString() => $"Тип: {Type ?? "Неизвестен"}, Наименование: {Name}, цена: {Price}";
}