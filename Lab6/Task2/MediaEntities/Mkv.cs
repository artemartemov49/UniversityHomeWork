using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.MediaEntities
{
    internal class Mkv : PlayerItem, IPlayable
    {
        public static readonly int CommandsCount = 3;

        public Mkv(string filePath) : base(filePath)
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
                    Play();
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
            Console.WriteLine("Mkv implementing IPlayable");
            Console.WriteLine("CommandList: play - 1, pause - 2, stop - 3");
        }

        public void Play()
        {
            Console.WriteLine("Play");
        }
    }
}