using YoutubeExplode;
using YoutubeExplode.Converter;
using System.Linq;

namespace MyYoutubeClient
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //ссылка на видео
            string url = "https://www.youtube.com/watch?v=Xd9A44oBkpU&ab_channel=levonevski_production";

            //создание объектов: отправитель, получатель, команда - получение информации о видео
            var sender = new SenderCommand();
            var receiver = new Receiver();
            var getInfoVideo = new GetInfoVideoCommand(receiver);

            /*1. отправка команды
             *2. получение информации о видео
            */
            sender.SetCommand(getInfoVideo);
            await sender.GetInfo(url);

            /*1. создание команды на скачивание видео
             *2. отправка команды на скачивание
             *3. Запуск скачивания
            */
            var downloadVideo = new DownloadCommand(receiver);
            sender.SetCommand(downloadVideo);
            await sender.DownLoad(url);

           
        }
    }
}