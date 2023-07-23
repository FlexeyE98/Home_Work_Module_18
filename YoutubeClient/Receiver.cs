using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using VideoLibrary;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace MyYoutubeClient
{
    /// <summary>
    /// Класс получателя команд
    /// </summary>
    class Receiver
    {
       private readonly YoutubeClient client;
        public Receiver()
        {
            client = new YoutubeClient();
        }

        public async Task GetInfoVideo(string url)
        {
            var info = await client.Videos.GetAsync(url);
            Console.WriteLine($"Название: {info.Title}");
            Console.WriteLine($"Автор: {info.Author}");
            Console.WriteLine($"Описание: {info.Description}");
        }

        public async Task DownloadVideol(string url, string outPathFile = @"C:\YoutubeClient\YoutubeClient\bin\Debug\netcoreapp3.1\")
        {

            Console.WriteLine();
            Console.WriteLine($"Видео скачано в: {outPathFile}");
            var streamManifest = await client.Videos.Streams.GetManifestAsync(url);
            var streamInfo = streamManifest.GetMuxedStreams()
                .Where(s => s.Container == Container.Mp4)
                .GetWithHighestVideoQuality();
            await client.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }
    }
}
