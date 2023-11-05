using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Task_18_Final
{
    //Команда для скачивания видео
    internal class DownloadCommand : ICommand
    {
        Video video;

        public DownloadCommand(Video video)
        {
            this.video = video;
        }

        public void Execute()
        {
            Task task = video.Download();
            task.Wait();
        }
    }
}
