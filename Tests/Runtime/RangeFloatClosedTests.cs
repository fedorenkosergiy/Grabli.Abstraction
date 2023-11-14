using NUnit.Framework;

namespace Grabli.Abstraction.Tests
{
    public class RangeFloatClosedTests
    {
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, -1.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f - float.Epsilon, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f + float.Epsilon, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 5.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 10.0f - float.Epsilon, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 10.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 10.0f + float.Epsilon, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 11.0f, false)]
        [TestCase(0.0f, -10.0f, RangeFloatClosed.EdgeInclusion.Both, -11.0f, false)]
        [TestCase(0.0f, -10.0f, RangeFloatClosed.EdgeInclusion.Both, -10.0f - float.Epsilon, true)]
        [TestCase(0.0f, -10.0f, RangeFloatClosed.EdgeInclusion.Both, -10.0f, true)]
        [TestCase(0.0f, -10.0f, RangeFloatClosed.EdgeInclusion.Both, -10.0f + float.Epsilon, true)]
        [TestCase(0.0f, -10.0f, RangeFloatClosed.EdgeInclusion.Both, -5.0f, true)]
        [TestCase(0.0f, -10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f - float.Epsilon, true)]
        [TestCase(0.0f, -10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f, true)]
        [TestCase(0.0f, -10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f + float.Epsilon, true)]
        [TestCase(0.0f, -10.0f, RangeFloatClosed.EdgeInclusion.Both, 1.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 5.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 5.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 5.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 5.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 0.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 0.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 0.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 10.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 10.0f, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 10.0f, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 10.0f, true)]
        public void CheckIncludes(float start, float length, RangeFloatClosed.EdgeInclusion edges, float value, bool expected)
        {
            RangeFloatClosed range = new RangeFloatClosed(start, length, edges);
            Assert.AreEqual(expected, range.Includes(value));
        }

        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, true)]
        
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.End, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.End, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Both, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 1.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Both, true)]

        
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Start, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Start, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Both, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 0.0f, 9.0f, RangeFloatClosed.EdgeInclusion.Both, true)]
        
        
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.None, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.Both, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Start, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.Both, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.End, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.Both, true)]
        [TestCase(0.0f, 10.0f, RangeFloatClosed.EdgeInclusion.Both, 1.0f, 8.0f, RangeFloatClosed.EdgeInclusion.Both, true)]
        public void CheckIncludes(float outerStart, float outerLength, RangeFloatClosed.EdgeInclusion outerEdges,
            float innerStart, float innerLength, RangeFloatClosed.EdgeInclusion innerEdges, bool expected)
        {
            RangeFloatClosed outer = new RangeFloatClosed(outerStart, outerLength, outerEdges);
            RangeFloatClosed inner = new RangeFloatClosed(innerStart, innerLength, innerEdges);
            Assert.AreEqual(expected, outer.Includes(inner));
        }
    }
}