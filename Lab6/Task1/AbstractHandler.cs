namespace Task1
{
    public abstract class AbstractHandler
    {
        public string FileName { get; set; }
        public string Format { get;}

        public AbstractHandler(string fileName, string format)
        {
            FileName = fileName;
            Format = format;

        }

       public abstract void Open();
       public abstract void Create();
       public abstract void Edit();
       public abstract void Delete();
    }
}
