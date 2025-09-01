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

    }
}