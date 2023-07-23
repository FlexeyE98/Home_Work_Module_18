using System;
using System.Collections.Generic;
using System.Text;

namespace MyYoutubeClient
{
    /// <summary>
    /// Класс отправитель команд
    /// </summary>
    class SenderCommand
    {
        ICommand command;

        public void SetCommand(ICommand command)
        { 
            this.command = command;
        }

       public async Task GetInfo(string urlVideo) 
        {
          await command.GetInfo(urlVideo);
        }

        public async Task DownLoad(string url, string outPathFile = @"C:\YoutubeClient\YoutubeClient\bin\Debug\netcoreapp3.1\")
        {
            await command.Download(url, outPathFile);
        }
    }
}
