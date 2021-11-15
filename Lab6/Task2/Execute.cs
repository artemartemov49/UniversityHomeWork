using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Task2.Interfaces;
using Task2.MediaEntities;

namespace Task2
{
    internal class Execute
    {
        static void Main(string[] args)
        {
            var playerItems = GetPlayerItemsFromDirectory(@"J:\Artem\study\gitRepForProgramming\Lab6\Task2\Media\");

            playerItems.ForEach(item => item.PlayerItemAction());
        }

        private static List<PlayerItem> GetPlayerItemsFromDirectory(string mediaPath)
        {
            return new DirectoryInfo(mediaPath)
                .GetFiles()
                .GetPlayerItems();
        }
    }
}