using System.Xml.Serialization;
using System.Xml.Linq;
namespace Project_8;
public class Task_4{
    public static void NoteBook(){
        XDocument xdoc = new XDocument();
        Console.Write("Person: ");
        XElement Person = new XElement("Person");
        string? name = Console.ReadLine() ?? "Unknown string";
        XAttribute PersonNameAttr = new XAttribute("name", name);
        XElement Address = new XElement("Address");
        Console.Write("Street: ");
        XElement Street = new XElement("Street", Console.ReadLine());
        Console.Write("HouseNumber: ");
        XElement HouseNumber = new XElement("HouseNumber", Console.ReadLine());
        Console.Write("FlatNumber: ");
        XElement FlatNumber = new XElement("FlatNumber", Console.ReadLine());
        Address.Add(Street);
        Address.Add(HouseNumber);
        Address.Add(FlatNumber);
        XElement Phones = new XElement("Phones");
        Console.Write("MobilePhone: ");
        XElement MobilePhone = new XElement("MobilePhone", Console.ReadLine());
        Console.Write("FlatPhone: ");
        XElement FlatPhone = new XElement("FlatPhone", Console.ReadLine());
        Phones.Add(MobilePhone);
        Phones.Add(FlatPhone);
        Person.Add(PersonNameAttr);
        Person.Add(Address);
        Person.Add(Phones);
        xdoc.Add(Person);
        xdoc.Save("Note_Book.xml");
    }
}