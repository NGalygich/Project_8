namespace Project_8;
public class Program{
    static public void Main(){
        Console.Write("Select Task: ");
        byte selectTask = Convert.ToByte(Console.ReadLine());
        switch (selectTask){
            case 1:
                Task_1.WorkList();
                break;
            case 2:
                Task_2.TelefonBook();
                break;
            case 3:
                Task_3.CatchPovtor();
                break;
            case 4:
                Task_4.NoteBook();
                break;
            default:
                break;
        }
    }
}