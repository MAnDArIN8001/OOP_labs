using System;

namespace OOP_lab_4 {
    internal class Boll {
        protected int _size;

        protected string _material;

        public int size { get => _size; }
        public string material { get => _material; }

        public Boll() { }

        public Boll(int size, string material) { 
            _size = size;
            _material = material;
        }

        public virtual void ThrowBoll() {
            Console.WriteLine("boll throwed");
        }
    }
}
