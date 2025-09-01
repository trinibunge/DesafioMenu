using System;
using System.Collections.Generic;


namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    
        public void AssignTable(Table table)
        {
            if (table == null) throw new ArgumentNullException(nameof(table));

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
            if (table == null) throw new ArgumentNullException(nameof(table));
            if (dish == null) throw new ArgumentNullException(nameof(dish));

            if (!assignedTables.Contains(table))
            {
                Console.WriteLine($"El mozo {Name} no tiene asignada la mesa {table.Number}.");
                return;
            }

            table.AddDish(dish);
            Console.WriteLine($"{Name} tomó el pedido: {dish.Name} para la mesa {table.Number}.");
        }
    }
}

