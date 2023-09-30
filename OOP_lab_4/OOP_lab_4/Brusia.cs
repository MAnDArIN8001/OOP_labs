namespace OOP_lab_4 {
    internal class Brusia : Item{
        private int _width;
        private int _height;

        public override void Communicate() {
            int randomTreaningsCount = new Random().Next(0, 20);

            Console.WriteLine($"u just did this ex. {randomTreaningsCount} times");
        }
    }
}
