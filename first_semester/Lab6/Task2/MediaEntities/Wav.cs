using System;
using Task2.Interfaces;

namespace Task2.MediaEntities
{
    internal class Wav : PlayerItem, IRecordable, IPlayable
    {
        public static readonly int CommandsCount = 4;

        public Wav(string filePath) : base(filePath)
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

        public void Play()
        {
            Console.WriteLine("Play");
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
                case 4:
                    Play();
                    break;
            }
        }


        public override void Info()
        {
            Console.WriteLine("Wav implementing IRecordable, IPlayable");
            Console.WriteLine("CommandList: record - 1, pause - 2, stop - 3, play - 4");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }
    }
}