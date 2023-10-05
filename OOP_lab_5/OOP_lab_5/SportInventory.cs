using System;
using OOP_lab_5.CustomExceptions;
using OOP_lab_5.Items;

namespace OOP_lab_5 {
    internal class SportInventory {
        private List<SportItem> _items;

        public List<SportItem> items { get => _items; }

        public SportInventory() { 
            _items = new List<SportItem>(); 
        }
        
        public SportInventory(List<SportItem> inventory) {
            _items = inventory;
        }

        public void SortByPrice() {
            _items.Sort((i1, i2) => i1.price.CompareTo(i2.price));
        }

        public void AddItem(SportItem newItem) {
            try {
                if (newItem == null)
                    throw new MissedItemException("this item is null");

                _items.Add(newItem);
            } catch(MissedItemException ex) { 
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveLast() {
            _items.RemoveAt(_items.Count-1);
        }

        public void RemoveFirst() {
            _items.RemoveAt(0);
        }
    }
}
