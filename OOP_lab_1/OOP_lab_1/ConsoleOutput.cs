using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_1
{
    internal class ConsoleOutput {
        public static void OutputArr(int[] arr) {
            foreach (var item in arr) {
                Console.Write($"{item}, ");
            }
        }

        public static void OutputArr(string[] arr) {
            foreach (var item in arr) {
                Console.Write($"{item}, ");
            }
        }
    }
}
