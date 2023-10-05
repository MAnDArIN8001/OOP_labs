using OOP_lab_5.Items;
using System;

namespace OOP_lab_5 {
    internal class InventoryController {
        private SportInventory _inventory;

        public int a;

        public InventoryController() {
            _inventory = new SportInventory();
        }

        public InventoryController(SportInventory inventory) {
            _inventory = inventory;
        }

        public void FilterByPrice(int minPrice, int maxPrice) {
            foreach (SportItem item in _inventory.items) {
                if (item.price >= minPrice && item.price <= maxPrice)
                    Console.WriteLine($"{item.name} - {item.price}");
            }
        }
    }
}
