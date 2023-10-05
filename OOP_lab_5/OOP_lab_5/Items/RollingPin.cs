using System;

namespace OOP_lab_5.Items {
    internal class RollingPin : SportItem {
        private float _length;

        public float length { get => _length; }

        public override void Comunicate() {
            int randomTime = new Random().Next(0, 10);

            Console.WriteLine($"u jumped for  {randomTime} mins");
        }
    }
}
