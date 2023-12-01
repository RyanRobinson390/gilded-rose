﻿using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace Tests
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void ThirtyDays()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { "30" });
            var output = fakeoutput.ToString();

            Approvals.Verify(output);
        }
    }
}