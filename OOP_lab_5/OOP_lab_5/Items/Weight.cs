using System;

namespace OOP_lab_5.Items {
    internal class Weight : SportItem {
        private float _weight;

        public float weight { get => _weight; }

        public override void Comunicate() {
            Console.WriteLine("U just pick it up few times");
        }
    }
}
