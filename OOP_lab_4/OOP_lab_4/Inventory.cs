using System;

namespace OOP_lab_4
{
    internal class Inventory {
        private string[] _items;

        private int _inventorySize = 32;

        public string[] items { get => _items; }

        public int inventorySize { get => _inventorySize; }

        public Inventory() {
            _items = new string[_inventorySize];
        }

        public void addItem(string item) {
            for(int i = 0; i < _inventorySize; i++) {
                if (_items[i] == null) {
                    _items[i] = item;
                }
            }
        }

        public override string ToString() {
            string result = "";

            foreach(string item in _items) {
                result += item + " ";
            }

            return result;
        }
    }
}
