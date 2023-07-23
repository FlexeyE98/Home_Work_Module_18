using System;
using System.Collections.Generic;
using System.Text;

namespace MyYoutubeClient
{
    /// <summary>
    /// Класс команды на скачивание
    /// </summary>
    class DownloadCommand : ICommand
    {
        private readonly Receiver _receiver;

        public DownloadCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public async Task Download(string videoUrl, string outputPathVideo)
        {
            await _receiver.DownloadVideol(videoUrl, outputPathVideo);
        }
        public async Task GetInfo(string videoUrl)
        {
            //без реализации, т.к команда на скачивание видео
        }
    }
}
