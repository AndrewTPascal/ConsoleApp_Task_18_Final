
namespace ConsoleApp_Task_18_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Video video = new Video("https://www.youtube.com/watch?v=KPXgBDqA27Q&ab_channel=Xinato_Official");
 
            invoker.SetCommand(new InfoCommand(video));
            invoker.Run();

            invoker.SetCommand(new DownloadCommand(video));
            invoker.Run();
        }
    }
}