using System.Text;
using NUnit.Framework;

namespace BasicCases
{
    internal class SteeringExamples
    {
        public void M()
        {
            var sb = new StringBuilder();
            sb.Append("");
            Assert.AreEqual("", "");
        }
    }
}