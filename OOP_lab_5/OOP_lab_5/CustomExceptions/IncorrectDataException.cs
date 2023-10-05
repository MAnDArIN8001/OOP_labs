using OOP_lab_5.Items;
using System;

namespace OOP_lab_5.CustomExceptions {
    internal class IncorrectDataException : Exception {
        public IncorrectDataException() {
            Console.WriteLine("Incorrect data");
        }

        public IncorrectDataException(string message) : base(message) { }

        public IncorrectDataException(string message, SportItem item) : base($"{message} in {item.GetHashCode()}") { }
    }
}
