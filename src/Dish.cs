namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        public string Name { get; }
        public Price Price { get; private set; }
        public bool IsVegetarian { get; }

        public Dish(string name, Price price, bool isVegetarian)
        {
            Name = name;
            Price = price;
            IsVegetarian = isVegetarian;
        }

        public void UpdatePrice(Price newPrice)
        {
            Price = newPrice;
        }
    }

    public class Price
    {
        public int Cost { get; }

        public Price(int cost)
        {
            Cost = cost;
        }
    }
}