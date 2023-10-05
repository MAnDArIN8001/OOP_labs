using System;

namespace OOP_lab_4 {
    internal partial class Boll {
        protected int _size;

        protected string _material;

        protected BollType _bollType;

        public int size { get => _size; }
        public string material { get => _material; }
        public BollType bollType { get => _bollType; }

        public Boll() { }

        public Boll(int size, string material) { 
            _size = size;
            _material = material;
        }

        public virtual void ThrowBoll() {
            Console.WriteLine("boll throwed");
        }
    }

    internal enum BollType {
        BasketBoll,
        FootBoll,
        TenisBoll,
        BowlingBoll
    }

    internal struct Point {
        public string player;

        public int score;
    }
}
