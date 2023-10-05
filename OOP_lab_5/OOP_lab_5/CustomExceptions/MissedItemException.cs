using System;

namespace OOP_lab_5.CustomExceptions {
    internal class MissedItemException : Exception {
        public MissedItemException() {
            Console.WriteLine("Some item was missed");
        }

        public MissedItemException(string message) : base(message) { }
    }
}
