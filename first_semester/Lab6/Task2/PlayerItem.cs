namespace Task2
{
    public abstract class PlayerItem
    {
        protected string FilePath { get; }

        protected PlayerItem(string filePath)
        {
            FilePath = filePath;
        }

        public abstract void Info();
    }
}