using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using YoutubeExplode.Converter;
using System.Linq;


namespace MyYoutubeClient
{
    /// <summary>
    /// Общий интерфейс команд
    /// </summary>
     interface ICommand
    {
        Task GetInfo(string videoUrl);
        Task Download(string videoUrl, string outputPathVideo);
      
    }
}
