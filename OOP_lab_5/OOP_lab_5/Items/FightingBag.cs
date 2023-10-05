using System;

namespace OOP_lab_5.Items {
    internal class FightingBag : SportItem {
        private int _size;

        public int size { get => _size; }

        public override void Comunicate() {
            int randomPower = new Random().Next(100, 1500);

            Console.WriteLine($"u just hit this fighting bag with {randomPower}kg strength");
        }
    }
}
