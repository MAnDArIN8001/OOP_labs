namespace OOP_lab_1
{
    internal class LocalArrays {
        public static (int, int, int, char) GetTupleResult(int[] arr, string str) {
            int max = arr[0], min = arr[0];

            int temp = SummOfElements(arr);

            foreach (var element in arr) {
                max = max <= element ? max : element; 
                min = min <= element ? min : element;
            }

            return (max, min, SummOfElements(arr), str[0]);

            int SummOfElements(int[] argumentsArr) {
                int sum = 0;

                foreach (var arg in argumentsArr) {
                    checked{
                        sum += arg;
                    }
                }

                return sum;
            }

            int SummOfElementsUnch(int[] argumentsArr) {
                int sum = 0;

                foreach (var arg in argumentsArr) {
                    unchecked {
                        sum += arg;
                    }
                }

                return sum;
            }
        }
    }
}
