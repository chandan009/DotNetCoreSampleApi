using System.Collections.Generic;
using Commander.Model;

namespace Commander.Data
{

    public class MockCommanderRepo : ICommandRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>()
            {
                new Command{Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Kettle & Pan"},
                new Command{Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Platform = "Knife & Chopping Board"},
                new Command{Id = 2, HowTo = "Make Cup of Tea", Line = "Place TeaBag in Cup", Platform = "Kettle & Cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return  new Command{Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Kettle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}