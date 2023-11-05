using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Search;
using YoutubeExplode.Videos.Streams;

namespace ConsoleApp_Task_18_Final
{
    //Получатель
    internal class Video
    {
        string videoUrl;

        public Video(string videoUrl) 
        {
            this.videoUrl = videoUrl;
        }

        //Информация о видео
        async public Task Info()
        {
            var youtube = new YoutubeClient();

            var video = await youtube.Videos.GetAsync(videoUrl);

            Console.WriteLine("Название видео: " + video.Title);
            Console.WriteLine("Автор канала: " + video.Author);
            Console.WriteLine("Длина видео: " + video.Duration);

        }

        //Скачать видео
        public async Task Download()
        {
            var youtube = new YoutubeClient();
 
            Console.WriteLine("Скачивание видео...");
            await youtube.Videos.DownloadAsync(videoUrl, "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));

            Console.WriteLine("Скачивание видео завершено!");
        }
    }
}
