public class Project_8{
    static public void Main(){
        Console.Write("Select Task: ");
        byte selectTask = Convert.ToByte(Console.ReadLine());
        switch (selectTask){
            case 1:
                WorkList();
                break;
            case 2:
                //TelefonBook();
                break;
            case 3:
                //CatchPovtor();
                break;
            case 4:
                //NoteBook();
                break;
            default:
                break;
        }
    }

    ///<summary>
    ///Метод выполнения первого задания
    ///</summary>
    static public void WorkList(){
        List<int> list = new List<int>();
        list =  RandList(list);
        WriteList(list);
        WriteList(RemoveList(list));
    }
    ///<summary>
    ///Метод записи коллекции List
    ///</summary>
    static public List<int> RandList(List<int> list){
        
        Random rand = new Random();
        for (int i = 0; i < 100; i++){
            list.Add(rand.Next(0,100));
        }
        return list;
    }
    ///<summary>
    ///Метод вывода коллекции List
    ///</summary>
    static public void WriteList(List<int> list){
        Console.Write("List: ");
        foreach(int el in list)
            Console.Write($"{el} ");
        Console.WriteLine();
    }
    ///<summary>
    ///Метод удаления определенного промежутка коллекции List
    ///</summary>
    static public List<int> RemoveList(List<int> list){
        List<int> listRemove = new List<int>();
        foreach(int el in list){
            if ((el < 25) || (el > 50))
                listRemove.Add(el);
        }
            
        return listRemove;
    }

}