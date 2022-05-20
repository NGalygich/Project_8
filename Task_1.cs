namespace Project_8{
    public class Task_1{
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
        static private List<int> RandList(List<int> list){
            
            Random rand = new Random();
            for (int i = 0; i < 100; i++){
                list.Add(rand.Next(0,100));
            }
            return list;
        }
        ///<summary>
        ///Метод вывода коллекции List
        ///</summary>
        static private void WriteList(List<int> list){
            Console.Write("List: ");
            foreach(int el in list)
                Console.Write($"{el} ");
            Console.WriteLine();
        }
        ///<summary>
        ///Метод удаления определенного промежутка коллекции List
        ///</summary>
        static private List<int> RemoveList(List<int> list){
            List<int> listRemove = new List<int>();
            foreach(int el in list){
                if ((el < 25) || (el > 50))
                    listRemove.Add(el);
            }
            return listRemove;
        }
    }
}