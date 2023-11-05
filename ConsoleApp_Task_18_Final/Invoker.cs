using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Task_18_Final
{
    // Отправитель
    internal class Invoker
    {
        ICommand command;

        public void SetCommand(ICommand command)
        { 
            this.command = command; 
        }

        public void Run() 
        {
            command.Execute();
        }

    }
}
