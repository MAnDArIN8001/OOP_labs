using System;

namespace OOP_lab_4
{
    internal class BasketBoll : Boll, ICommunicatable {
        private float _jumpScale;

        public float jumpScale {
            get => _jumpScale;
        }

        public BasketBoll(int size, float jumpScale, string material) : base(size, material) { 
            _jumpScale = jumpScale;
        }

        public override string ToString() {
            return $"this is basketboll, size of: {_size}, jump scale: {_jumpScale}, material: {_material}";
        }

        public override void ThrowBoll() {
            Console.WriteLine("Basketboll throwed");
        }

        public void Communicate() {
            Console.WriteLine("U comunicated with this obj");
        }

        public bool IsCommunicationSucsesed() {
            return new Random().Next(0, 1) == 1 ? true : false;
        }
    }
}
