using Module3HW1.Services;

namespace Module3HW1
{
    public class Programm
    {
        public static void Main()
        {
            MyList myList = new MyList();
            AddService addService = new AddService();
            myList.list = addService.Add(myList.list, 1);
            foreach (var item in myList.list)
            {
                if (item != 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

}