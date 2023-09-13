using System.Text;
using OOP_lab_1;

bool flag = true;

string userAns;

while(flag) {
    Console.Write("1-first task, 2-second task, 3-third task, 4-fourth task, 5-fivth task");
    userAns = Console.ReadLine();

    switch (userAns) {
        case "1":
            var primitiv = new Primitiv();

            primitiv.OutputData();
            primitiv.ExplicitConversion();
            primitiv.UnexplicitConversion();
            break;

        case "2":
            StringOperator stringOperator = new StringOperator();

            stringOperator.FirstStrTasks();
            stringOperator.StringBuilderTasks();
            break;

        case "3":
            Matrix matrix = new Matrix(3);
            matrix.OutputMatrix();

            var arr = new[] { "test", "lmao", "lol", "stfp" };

            Console.WriteLine($"\nlength: {arr.Length}");
            ConsoleOutput.OutputArr(arr);

            Console.Write("Enter index of element, that u wanna change: ");
            int index = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

            Console.Write("enter new value: ");
            arr[index] = Console.ReadLine();

            SharpArray<float> sharpArr = new SharpArray<float>(3);
            sharpArr.OutputArray();

            var varArr = new[] { 5, 8, 3 };
            ConsoleOutput.OutputArr(varArr);
            break;

        case "4":
            (int, string, char, string, long) testCorteg = (8, "test",'h',"str", 90);
            (int, string, char, string, long) tupleForComparing = (9, "str", 'h', "str", 11);

            Console.WriteLine($"full cortage{testCorteg.ToString()} some elements of cortage: {testCorteg.Item1}, {testCorteg.Item2}");

            var (first, second, third, fourth, _) = testCorteg;
            Console.WriteLine(first);

            Console.WriteLine(testCorteg == tupleForComparing);
            break;
        
        case "5":
            var (max, min, sum, firstLetter) = LocalArrays.GetTupleResult(new int[] { 2, 3, 4, 5, 90, 98 }, "test str");
            break;
    }

    Console.Write("Wanna continye?(y/n)");

    flag = Console.ReadLine() == "y" ? true : false;
}

