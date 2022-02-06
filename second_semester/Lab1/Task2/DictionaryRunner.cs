namespace Task2
{
    internal class DictionaryRunner
    {
        static void Main(string[] args)
        {
            var myDictionary = new MyDictionary<string, int>(3);
            myDictionary.Add("hello", 5);
            myDictionary.Add("1", 1);
            myDictionary.Add("2", 2);
            myDictionary.Add("3", 3);
            myDictionary.Add("3", 5);

            var i = myDictionary.Get("3");
            Console.WriteLine(i);
        }
    }
}