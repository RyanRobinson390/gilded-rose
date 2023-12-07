using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using Data;
using Domain.Runners;
using Domain.Writers;
using NUnit.Framework;

namespace Tests
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class ApprovalTest
    {
        private GildedRoseProcessor _processor;

        [SetUp]
        public void SetUp()
        {
            _processor = new GildedRoseProcessor(new ItemRepository(), new ConsoleWriter());
        }

        [Test]
        public void ThirtyDays()
        {
            var applicationOutput = new StringBuilder();
            Console.SetOut(new StringWriter(applicationOutput));
            Console.SetIn(new StringReader("a\n"));

            _processor.Run();
            var output = applicationOutput.ToString();

            Approvals.Verify(output);
        }
    }
}
