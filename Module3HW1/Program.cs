using Module3HW1.Services;

namespace Module3HW1
{
    public class Programm
    {
        public static void Main()
        {
            MyList myList = new MyList();
            AddService addService = new AddService();
            AddRange addRange = new AddRange();
            int[] range = new int[] {5, 6, 7};
            myList.list = addService.Add(myList.list, 1);
            myList.list = addRange.Addrange(myList.list, range);
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