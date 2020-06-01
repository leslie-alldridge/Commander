using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
               new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
               new Command{Id=1, HowTo="Cut Bread", Line="Get a knife", Platform="Cutting board"},
               new Command{Id=2, HowTo="Peel a potato", Line="Peeling", Platform="Peel skin off"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
        }
    }
}