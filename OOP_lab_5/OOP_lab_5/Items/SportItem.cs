using System;

namespace OOP_lab_5.Items {
    internal abstract class SportItem {
        protected int _price;

        protected string _name;

        public int price { get => price; }
        public string name { get => name; }

        public SportItem() { _price = 0; }

        public SportItem(int price, string name) {
            _price = price;
            _name = name;
        }

        public abstract void Comunicate();
    }
}
