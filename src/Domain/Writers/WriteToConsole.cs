using Domain.Interfaces;

namespace Domain.Writers
{
    public class ConsoleWriter : IWriteOutput
    {
        public void WriteOutput(string message)
        {
            Console.WriteLine(message);
        }
    }
}
