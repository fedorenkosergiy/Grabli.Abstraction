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

        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 0.0f, 10.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 0.0f, 10.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 0.0f, 10.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f, 10.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 0.0f, 10.0f, RangeFloat.EdgeInclusion.End, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 0.0f, 10.0f, RangeFloat.EdgeInclusion.End, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 0.0f, 10.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f, 10.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, true)]
        
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 1.0f, 9.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 1.0f, 9.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 1.0f, 9.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 1.0f, 9.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 1.0f, 9.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 1.0f, 9.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 1.0f, 9.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 1.0f, 9.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 1.0f, 9.0f, RangeFloat.EdgeInclusion.End, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 1.0f, 9.0f, RangeFloat.EdgeInclusion.End, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 1.0f, 9.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 1.0f, 9.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 1.0f, 9.0f, RangeFloat.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 1.0f, 9.0f, RangeFloat.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 1.0f, 9.0f, RangeFloat.EdgeInclusion.Both, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 1.0f, 9.0f, RangeFloat.EdgeInclusion.Both, true)]

        
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 0.0f, 9.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 0.0f, 9.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 0.0f, 9.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f, 9.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 0.0f, 9.0f, RangeFloat.EdgeInclusion.Start, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 0.0f, 9.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 0.0f, 9.0f, RangeFloat.EdgeInclusion.Start, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f, 9.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 0.0f, 9.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 0.0f, 9.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 0.0f, 9.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f, 9.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 0.0f, 9.0f, RangeFloat.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 0.0f, 9.0f, RangeFloat.EdgeInclusion.Both, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 0.0f, 9.0f, RangeFloat.EdgeInclusion.Both, false)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 0.0f, 9.0f, RangeFloat.EdgeInclusion.Both, true)]
        
        
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 1.0f, 8.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 1.0f, 8.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 1.0f, 8.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 1.0f, 8.0f, RangeFloat.EdgeInclusion.None, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 1.0f, 8.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 1.0f, 8.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 1.0f, 8.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 1.0f, 8.0f, RangeFloat.EdgeInclusion.Start, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 1.0f, 8.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 1.0f, 8.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 1.0f, 8.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 1.0f, 8.0f, RangeFloat.EdgeInclusion.End, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.None, 1.0f, 8.0f, RangeFloat.EdgeInclusion.Both, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Start, 1.0f, 8.0f, RangeFloat.EdgeInclusion.Both, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.End, 1.0f, 8.0f, RangeFloat.EdgeInclusion.Both, true)]
        [TestCase(0.0f, 10.0f, RangeFloat.EdgeInclusion.Both, 1.0f, 8.0f, RangeFloat.EdgeInclusion.Both, true)]
        public void CheckIncludes(float outerStart, float outerLength, RangeFloat.EdgeInclusion outerEdges,
            float innerStart, float innerLength, RangeFloat.EdgeInclusion innerEdges, bool expected)
        {
            RangeFloat outer = new RangeFloat(outerStart, outerLength, outerEdges);
            RangeFloat inner = new RangeFloat(innerStart, innerLength, innerEdges);
            Assert.AreEqual(expected, outer.Includes(inner));
        }
    }
}