using System;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        
        class Command
        {
            public string commandline { get; set; }
        }

        List<Command> commands = new List<Command>();
        bool state = false;
        public void Run()
        {
            while (!state) {
                Console.WriteLine("Close by typing \"Close\" \nReset saved commands by typing \"Reset\" \nMessage:");
                Command command = new Command();
                command.commandline = Console.ReadLine();

                if (command.commandline == "Close") {
                    state = !state;
                } else if(command.commandline == "Reset") {
                    commands.Clear();
                }
                else {
                    commands.Add(command);
                }
            }
            for(int i = 0; i < commands.Count; i++) {
                Console.WriteLine($"Index: {i}, Message: {commands[i].commandline}");
            }
        }
    }
}