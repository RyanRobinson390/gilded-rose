using Domain.Interfaces;

namespace Domain.Writers
{
    public class ConsoleWriter : IWriteOutput
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteNewDayHeader(int day)
        {
            Console.WriteLine($"-------- day {day} --------");
            Console.WriteLine("name, sellIn, quality");
        }
    }
}
