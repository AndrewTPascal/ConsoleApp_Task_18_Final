using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Task_18_Final
{
    //Команда для просмотра информации о видео
    internal class InfoCommand : ICommand
    {
        Video video;
        public InfoCommand(Video video)
        { 
            this.video = video; 
        }
        public void Execute() 
        {
            Task task = video.Info();
            task.Wait();
        }

    }
}
