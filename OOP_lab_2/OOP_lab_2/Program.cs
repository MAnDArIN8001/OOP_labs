using OOP_lab_2;

string userAnsw;

int busesCount = 0;

List<Bus> buses = new List<Bus>();

Console.Write("Enter buses count: ");
busesCount = int.Parse(Console.ReadLine());

for (int i = 0; i < busesCount; i++) {
    buses.Add(new Bus());
}

int routeId = 0;

Console.Write("Enter route that u wanna find: ");
routeId = int.Parse(Console.ReadLine());

foreach (var item in buses) {
    if (routeId == item.routeId) {
        Console.WriteLine($"bus id: {item.busId}");
    }
}

Console.WriteLine($"first bus hash is: {buses[0].GetHashCode()}, and last bus hash is: {buses[buses.Count-1].GetHashCode()}");

int busAge = 0;

Console.Write("\nEnter age: ");
busAge = int.Parse(Console.ReadLine());

foreach (var item in buses) {
    if (busAge <= item.GetBusAge()) {
        Console.WriteLine($"bus id: {item.busId}, age: {item.GetBusAge()}");
    }
}

