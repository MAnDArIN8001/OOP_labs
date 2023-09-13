using System;
using System.Text;

namespace OOP_lab_1 {
    internal class StringOperator {
        private string _firstStr;
        private string _secondStr;

        private const string DefaultValue = "this is default text value";

        public string firstStr { get => _firstStr; }
        public string secondStr { get => _secondStr; }

        public StringOperator(string firstStr, string secondStr) {
            _firstStr = firstStr;
            IsEptyToDefault(ref _firstStr);

            _secondStr = secondStr;
            IsEptyToDefault(ref _secondStr);

            Console.WriteLine(CompareStrs());
        }

        public StringOperator() {
            Console.Write("Enter first str: ");
            _firstStr = Console.ReadLine();

            IsEptyToDefault(ref _firstStr);

            Console.WriteLine("Enter second str: ");
            _secondStr = Console.ReadLine();

            IsEptyToDefault(ref _secondStr);

            Console.WriteLine(CompareStrs());
        }

        public bool CompareStrs() => _firstStr == _secondStr;

        public void FirstStrTasks() {
            char[] copyResult = new char[_firstStr.Length];

            string strToAdd;

            _firstStr.CopyTo(0, copyResult, 0, _firstStr.Length / 2);

            Console.WriteLine("Enter str that u wanna add");
            strToAdd = Console.ReadLine();

            _firstStr += strToAdd;

            Console.WriteLine($"copy to - {copyResult.ToString()}");
            Console.WriteLine($"substring - {_firstStr.Substring(0, _firstStr.Length / 2)}\n");

            ConsoleOutput.OutputArr(_firstStr.Split(' '));

            _firstStr.Insert(_firstStr.IndexOf(' '), strToAdd);

            Console.WriteLine($"\n{_firstStr}");
            Console.WriteLine($"\n{_firstStr.Remove(_firstStr.IndexOf(' '), _firstStr.LastIndexOf(' '))}");
        }

        public void StringBuilderTasks() {
            StringBuilder sb = new StringBuilder("simple text");

            Console.Write("\nWhat do you wanna insert in front: ");
            sb.Append(Console.ReadLine());

            Console.Write("\n What do you wanna insert in back: ");
            sb.AppendFormat(Console.ReadLine());

            char letterToChange, letterReplace;

            Console.WriteLine("letter to change: ");
            letterToChange = Console.ReadLine()[0];

            Console.WriteLine("letter replace: ");
            letterReplace = Console.ReadLine()[0];

            sb.Replace(letterToChange, letterReplace);
            Console.WriteLine(sb);
        }

        private void IsEptyToDefault(ref string str) {
            if (string.IsNullOrEmpty(str)){ str = DefaultValue; }
        }
    }
}
