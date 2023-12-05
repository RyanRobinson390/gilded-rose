using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using Domain.Runners;
using NUnit.Framework;

namespace Tests
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class ApprovalTest
    {
        private GildedRoseRunner _runner;

        [SetUp]
        public void SetUp()
        {
            _runner = new GildedRoseRunner();
        }

        [Test]
        public void ThirtyDays()
        {
            var applicationOutput = new StringBuilder();
            Console.SetOut(new StringWriter(applicationOutput));
            Console.SetIn(new StringReader("a\n"));

            _runner.Run();
            var output = applicationOutput.ToString();

            Approvals.Verify(output);
        }
    }
}
