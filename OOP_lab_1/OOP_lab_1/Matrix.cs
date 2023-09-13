using System;

namespace OOP_lab_1
{
    internal class Matrix {
        private int _matrixSize;

        private Nullable<int>[,] _matrix;

        public Nullable<int>[,] matrix { get => _matrix; }

        public Matrix(int matrixSize) {
            _matrix = new Nullable<int>[matrixSize, matrixSize];
            _matrixSize = matrixSize;

            for(int i = 0; i < matrixSize; i++) {
                for(int j = 0; j < matrixSize; j++) {
                    Console.Write("enter element of matrix: ");
                    _matrix[i, j] = int.TryParse(Console.ReadLine(), out int result) ? result : null; 
                }
            }
        }

        public void OutputMatrix() {
            Console.WriteLine();

            for (int i = 0; i < _matrixSize; i++) {
                for (int j = 0; j < _matrixSize; j++) {
                    Console.Write($"{_matrix[i, j]}\t");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
