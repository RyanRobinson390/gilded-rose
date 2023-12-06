namespace Domain.Interfaces;

public interface IWriteOutput
{
    void WriteLine(string message);
    void WriteNewDayHeader(int day);
}