using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Task2.Interfaces;
using Task2.MediaEntities;
using static UtilsParser.ParserUtil;

namespace Task2
{
    public static class UtilsMedia
    {
        public static readonly List<string> PlayableList = new() {"mkv"};
        public static readonly List<string> RecordableList = new() {"mp3"};
        public static readonly List<string> AllList = new() {"wav"};

        public static List<PlayerItem> GetPlayerItems(this FileInfo[] fileInfos)
        {
            return (from file in fileInfos
                where file.IsMediaFile()
                select file.GetPlayerItemByFileInfo()).ToList();
        }


        private static bool IsMediaFile(this FileInfo fileInfo)
        {
            if (string.IsNullOrEmpty(fileInfo.Extension))
            {
                return false;
            }

            var extension = RemoveDotFromExtension(fileInfo.Extension);

            return PlayableList.Contains(extension)
                   || RecordableList.Contains(extension)
                   || AllList.Contains(extension);
        }

        private static PlayerItem GetPlayerItemByFileInfo(this FileInfo fileInfo)
        {
            var fileFullPath = fileInfo.FullName;

            if (string.IsNullOrEmpty(fileFullPath))
            {
                throw new Exception("This file is empty");
            }

            var extension = RemoveDotFromExtension(fileInfo.Extension);

            if (PlayableList.Contains(extension))
            {
                return new Mkv(fileFullPath);
            }

            if (RecordableList.Contains(extension))
            {
                return new Mp3(fileFullPath);
            }

            if (AllList.Contains(extension))
            {
                return new Wav(fileFullPath);
            }

            throw new Exception("This file cannot be converted to media");
        }

        private static string RemoveDotFromExtension(string extension)
        {
            return extension.Replace(".", "");
        }

        public static void PlayerItemAction<T>(this T playerItem) where T : PlayerItem
        {
            playerItem.Info();

            switch (playerItem)
            {
                case Mkv mkv:
                    MkvAction(mkv);
                    break;
                case Mp3 mp3:
                    Mp3Action(mp3);
                    break;
                case Wav wav:
                    WavAction(wav);
                    break;
            }
        }

        private static void MkvAction(Mkv mkv)
        {
            var commandNumber = ValidateAndParseIntRange("command", 0, Mkv.CommandsCount);
            mkv.Execute(commandNumber);
        }

        private static void Mp3Action(Mp3 mp3)
        {
            var commandNumber = ValidateAndParseIntRange("command", 0, Mp3.CommandsCount);
            mp3.Execute(commandNumber);
        }

        private static void WavAction(Wav wav)
        {
            var commandNumber = ValidateAndParseIntRange("command", 0, Wav.CommandsCount);
            wav.Execute(commandNumber);
        }
    }
}