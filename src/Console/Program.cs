using Data;
using Domain.Runners;
using Domain.Writers;

var processor = new GildedRoseProcessor(new ItemRepository(), new ConsoleWriter());
processor.Run();
