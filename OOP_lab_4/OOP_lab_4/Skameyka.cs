namespace OOP_lab_4
{
    internal class Skameyka : Item{
        private int _seatingPlaces = 6;
        private int _curentSeatingCount;

        public Skameyka() { }

        public override void Communicate() {
            string answer = _curentSeatingCount < _seatingPlaces ? "you just chealing" : "u cant seat here";
            _curentSeatingCount++;

            Console.WriteLine(answer);
        }
    }
}
