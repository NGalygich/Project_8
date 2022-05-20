namespace Project_8;
public class Task_2{
    public static void TelefonBook(){ 
        Search(WriteEntry());
        Console.ReadLine();
        Console.Clear();
    }
    private static Dictionary<string, string> WriteEntry(){
        Dictionary<string, string> telefonBook = new Dictionary<string, string>();
        while(1 == 1){
            Console.Write("Enter full name: ");
            string? fullName = Console.ReadLine() ?? "Unknown string";
            if (fullName == "")
                break;
            else {
                Console.Write("Enter number: ");
                string? number = Console.ReadLine() ?? "Unknown string";
                if (number == "")
                    break;
                telefonBook.Add(number, fullName);
            }
        }
        Console.Clear();    
        return telefonBook;
    }
    private static void Search(Dictionary<string, string> telefonBook){
        Console.Write("Serch number: ");
        string? number = Console.ReadLine() ?? "Unknown string";
        if (telefonBook.ContainsKey(number))
            Console.WriteLine($"{telefonBook[number]}: {number}");
        else
            Console.WriteLine("Number not found");
    }
}