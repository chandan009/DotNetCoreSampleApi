using System.Collections.Generic;
using Commander.Model;

namespace Commander.Data
{
    public interface ICommandRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
        bool SaveChanges();
    }
    
}