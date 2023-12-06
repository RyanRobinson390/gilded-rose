using Data;
using Domain.Runners;
using Domain.Writers;

var runner = new GildedRoseRunner(new ItemRepository(), new ConsoleWriter());
runner.Run();
