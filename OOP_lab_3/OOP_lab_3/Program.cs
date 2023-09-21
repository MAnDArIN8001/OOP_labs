using OOP_lab_3;

int elementsCount = 0;

List firstList = new List();
List secondList = new List();

Console.Write("Enter count of elements: ");
int.TryParse(Console.ReadLine(), out  elementsCount);

Console.WriteLine("\nFirstList\n");

for (int i = 0; i < elementsCount; i++) {
    int temp = 0;

    Console.Write("Enter Value: ");
    int.TryParse(Console.ReadLine(), out temp);

    firstList.Add(temp);
}

Console.WriteLine("\nSecondList\n");

for (int i = 0; i < elementsCount; i++) {
    int temp = 0;

    Console.Write("Enter Value: ");
    int.TryParse(Console.ReadLine(), out temp);

    secondList.Add(temp);
}

List newList = firstList + secondList;
newList.OutputList();

if (firstList == secondList) Console.WriteLine("Lists is equalas\n");

List reversedList = !newList;
reversedList.OutputList();
