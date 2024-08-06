using CommandDesignPattern.Models;

namespace CommandDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //on
            Television television = new Television();
            ICommand command = new OnCommand(television);
            RemoteControl remoteControl = new RemoteControl();
            remoteControl.SetCommand(command);
            remoteControl.PressButton();

            //off
            command = new OffCommand(television);
            remoteControl = new RemoteControl();
            remoteControl.SetCommand(command);
            remoteControl.PressButton();
        }
    }
}
