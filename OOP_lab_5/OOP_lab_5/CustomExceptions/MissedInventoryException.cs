using System;

namespace OOP_lab_5.CustomExceptions {
    internal class MissedInventoryException : Exception {
        public MissedInventoryException() {
            Console.WriteLine("Current inventory was missed");
        }

        public MissedInventoryException(string message) : base(message) { }
    }
}
