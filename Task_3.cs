namespace Project_8;
public class Task_3{
    public static void CatchPovtor(){
        HashSet<int> hashNum = new HashSet<int>();
        while (1 == 1){
            Console.Write("Enter number: ");
            int number = (Convert.ToInt32(Console.ReadLine()));
            if (hashNum.Contains(number)){
                Console.WriteLine("Hash have number");
                break;
            }
            hashNum.Add(number);
            Console.WriteLine("Number save in hash");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
