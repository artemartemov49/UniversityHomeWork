namespace Task1
{
    internal class ListRunner
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>(1);
            myList.Add(1);
            myList.Add(3);
            var item = myList.Get(0);
            myList.Contains(3);
            myList.Contains(-53);
            Console.WriteLine(item);
            Console.WriteLine("[{0}]", string.Join(", ", myList.GetArray()));
        }
    }
}