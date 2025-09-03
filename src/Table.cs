using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private List<Dish> order = new List<Dish>();
        public int Number { get; private set; }
        public bool IsOccupied { get; private set; }

        public Table(int number, bool isOccupied = false)
        {
            this.Number = number;
            this.IsOccupied = isOccupied;
        }
        
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
        
        public void Ocupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear();
        }

        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }

    }
}