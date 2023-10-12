using OOP_lab_4;

Item item = new Mat();
item.Communicate();

ICommunicatable basketboll = new BasketBoll(10, 5f, "rezina");
basketboll.Communicate();

if(basketboll is ICommunicatable) {
    Console.WriteLine(true);
}

BasketBoll boll = basketboll as BasketBoll;

Type type = boll.GetType();

Console.WriteLine(type);
