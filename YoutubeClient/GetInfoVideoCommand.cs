using System;
using System.Collections.Generic;
using System.Text;

namespace MyYoutubeClient
{
    /// <summary>
    /// Класс команды на получение информации видео
    /// </summary>
    class GetInfoVideoCommand : ICommand
    {
        private readonly Receiver _receiver;

        public GetInfoVideoCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public async Task Download(string videoUrl, string outputPathVideo)
        {
            //без реализация т.к команда на получение информации о видео
        }

        public async Task GetInfo(string videoUrl)
        {
            await _receiver.GetInfoVideo(videoUrl);
        }
    }
}
