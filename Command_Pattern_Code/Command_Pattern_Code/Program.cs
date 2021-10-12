using Command_Pattern_Code.Clients;
using Command_Pattern_Code.Commands;
using Command_Pattern_Code.Interfaces;
using Command_Pattern_Code.Invokers;
using System;
using System.Collections.Generic;

namespace Command_Pattern_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            // get teh client (remote control) that we are going to use by asking the client what is controlling.

            IReceiver receiver = Client.getClient();

            //Create the commands the remote will execute on the reiever
            ICommand turnOnCommand = new CommandTurnOn(receiver);
            ICommand turnOffCommand = new CommandTurnOff(receiver);


            //Create the invokers (buttons) that will invoke the commands.
            Invoker invokeOn = new Invoker(turnOnCommand);
            Invoker invokeOff = new Invoker(turnOffCommand);

            //You can invoke command to execute in realtime

            //invokeOn.ExecuteCommand();
            //invokeOff.ExecuteCommand();
            //invokeOff.UndoCommand();

            //or queue up comands to execute on the device

            List<Invoker> commands = new List<Invoker>();
            commands.Add(invokeOn);
            commands.Add(invokeOff);
            commands.Add(invokeOn);
            commands.Add(invokeOff);

            foreach (Invoker button in commands)
            {
                button.ExecuteCommand();

            }

            commands[commands.Count - 1].UndoCommand();

            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
