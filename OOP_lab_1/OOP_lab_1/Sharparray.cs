using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_1
{
    internal class SharpArray<T>
    {
        private T[][] _sharpArr;

        public T[][] sharpArr { get => _sharpArr; }

        public SharpArray(int mainSize) {
            _sharpArr = new T[mainSize][];

            for (int i = 0; i < _sharpArr.Length; i++) {
                Console.Write("enter size of first arr: ");
                int.TryParse(Console.ReadLine(), out int parsResult);

                _sharpArr[i] = new T[parsResult];

                for (int j = 0; j < _sharpArr[i].Length; j++) {
                    Console.Write("Enter value: ");
                    _sharpArr[i][j] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                }

                Console.WriteLine("\n");
            }
        }

        public void OutputArray() {
            foreach (var item in _sharpArr) {
                foreach (var subArrItem in item) {
                    Console.Write($"{subArrItem}\t");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
