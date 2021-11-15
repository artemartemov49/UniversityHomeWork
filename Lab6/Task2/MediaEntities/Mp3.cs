using System;
using Task2.Interfaces;

namespace Task2.MediaEntities
{
    internal class Mp3 : PlayerItem, IRecordable
    {
        public static readonly int CommandsCount = 3;

        public Mp3(string filePath) : base(filePath)
        {
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public void Execute(int commandNumber)
        {
            switch (commandNumber)
            {
                case 1:
                    Record();
                    break;
                case 2:
                    Pause();
                    break;
                case 3:
                    Stop();
                    break;
            }
        }
        public override void Info()
        {
            Console.WriteLine("Mp3 implementing IRecordable");
            Console.WriteLine("CommandList: record - 1, pause - 2, stop - 3");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }
    }
}