using System;
using System.Collections.Generic;


namespace Ucu.Poo.Restaurant
{

    public class Waiter
    {
        public string Name { get; set; }
        private List<Table> assignedTables = new List<Table>();

        public Waiter(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("El nombre no puede estar vacío");
            }

            Name = name;
        }

        public void AssignTable(Table table)
        {
            if (!assignedTables.Contains(table))
            {
                assignedTables.Add(table);
            }
            else
            {
                Console.WriteLine($"La mesa {table.Number} ya está asignada a {Name}.");
            }
        }

        public void TakeOrder(Table table, Dish dish)
        {

            if (!assignedTables.Contains(table))
            {
                Console.WriteLine($"El mozo {Name} no tiene asignada la mesa {table.Number}.");
                return;
            }

            table.AddDish(dish);
            Console.WriteLine($"{Name} tomó el pedido: {dish.Name} para la mesa {table.Number}.");
        }

    }

}§