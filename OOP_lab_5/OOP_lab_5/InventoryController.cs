using OOP_lab_5.Items;
using System;
using OOP_lab_5.CustomExceptions;

namespace OOP_lab_5 {
    internal class InventoryController {
        private SportInventory _inventory;

        public InventoryController() {
            _inventory = new SportInventory();
        }

        public InventoryController(SportInventory inventory) {
            _inventory = inventory;
        }

        public void FilterByPrice(int minPrice, int maxPrice) {
            try {
                if (_inventory == null)
                    throw new MissedInventoryException();

                foreach (SportItem item in _inventory.items) {
                    if (item.price < 0)
                        throw new IncorrectDataException("Price cant be lower then 0");

                    if (item.price >= minPrice && item.price <= maxPrice)
                        Console.WriteLine($"{item.name} - {item.price}");
                }
            } catch(IncorrectDataException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void ActivateRebootControll() { 
            try {
                RebootInventory();
            } catch(Exception err) {
                Console.WriteLine(err.Message);
            }
        }

        public void RebootInventory() {
            List<string> test = null;

            try {
                if (test == null)
                    throw new Exception();
            } catch(Exception err) {
                Console.WriteLine(err.Message);
                Console.WriteLine($"Place: {err.TargetSite}");
                Console.WriteLine($"Diagnostic: {err.StackTrace}");

                throw;
            }
        }
    }
}
