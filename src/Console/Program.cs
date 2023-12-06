using Data;
using Domain.Runners;

var runner = new GildedRoseRunner(new ItemRepository());
runner.Run();
