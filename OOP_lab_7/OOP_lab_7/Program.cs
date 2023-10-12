using OOP_lab_7;
using System.Collections.Generic;
using System.Xml.Serialization;

XmlSerializer serialaizer = new XmlSerializer(typeof(User<int>));

StreamWriter writer = new StreamWriter("dataFile.txt");

User<int> user = new User<int>(123, "john", "email@gm.com", "16hf6");

RefList<int> list = new RefList<int>();

list.Add(0);
list.Add(1);
list.Add(2);

try {
    serialaizer.Serialize(writer, user);

    writer.Close();
} catch (Exception err) {
    Console.WriteLine(err.Message);
}

