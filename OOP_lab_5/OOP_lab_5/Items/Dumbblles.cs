using System;

namespace OOP_lab_5.Items {
    internal class Dumbblles : SportItem {
        private float _weight;

        public float weight { get => _weight; }

        public override void Comunicate() {
            Console.WriteLine("u did few dumbs");
        }
    }
}
