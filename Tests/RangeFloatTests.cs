using NUnit.Framework;

namespace Grabli.Abstraction.Tests
{
    public class RangeFloatTests
    {
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, -1.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f - float.Epsilon, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f + float.Epsilon, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 5.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 10.0f - float.Epsilon, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 10.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 10.0f + float.Epsilon, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 11.0f, false)]
        [TestCase(0.0f, -10.0f, RangeFloat.EdgeInclusion.Both, -11.0f, false)]
        [TestCase(0.0f, -10.0f, RangeFloat.EdgeInclusion.Both, -10.0f - float.Epsilon, true)]
        [TestCase(0.0f, -10.0f, RangeFloat.EdgeInclusion.Both, -10.0f, true)]
        [TestCase(0.0f, -10.0f, RangeFloat.EdgeInclusion.Both, -10.0f + float.Epsilon, true)]
        [TestCase(0.0f, -10.0f, RangeFloat.EdgeInclusion.Both, -5.0f, true)]
        [TestCase(0.0f, -10.0f, RangeFloat.EdgeInclusion.Both, 0.0f - float.Epsilon, true)]
        [TestCase(0.0f, -10.0f, RangeFloat.EdgeInclusion.Both, 0.0f, true)]
        [TestCase(0.0f, -10.0f, RangeFloat.EdgeInclusion.Both, 0.0f + float.Epsilon, true)]
        [TestCase(0.0f, -10.0f, RangeFloat.EdgeInclusion.Both, 1.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 5.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 5.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 5.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 5.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 0.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 0.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 0.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 10.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 10.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 10.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 10.0f, true)]
        public void CheckIncludes(float start, float length, RangeFloat.EdgeInclusion edges, float value, bool expected)
        {
            RangeFloat range = new RangeFloat(start, length, edges);
            Assert.AreEqual(expected, range.Includes(value));
        }
    }
}