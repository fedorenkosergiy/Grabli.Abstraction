using JetBrains.Annotations;
using static System.Math;

namespace Grabli.Abstraction
{
	[PublicAPI]
	public partial struct RangeFloat
	{
		public float Start;
		public float Length;
		public EdgeInclusion Edges;

		public bool IncludesStart => (Edges & EdgeInclusion.Start) == EdgeInclusion.Start;

		public bool IncludesEnd => (Edges & EdgeInclusion.End) == EdgeInclusion.End;

		public float End => Start + Length;

		public RangeFloat(float start, float length, EdgeInclusion edges)
		{
			Start = start;
			Length = length;
			Edges = edges;
		}

		public bool Includes(float value)
		{
			return Length switch
			{
			> 0.0f => IncludesInCaseOfPositiveLength(value),
			< 0.0f => IncludesInCaseOfNegativeLength(value),
			_ => EqualsToOneOfEdges(value, out bool includes) && includes
			};
		}

		private bool IncludesInCaseOfNegativeLength(float value)
		{
			if (EqualsToOneOfEdges(value, out bool includes)) return includes;

			return !(value < End) && !(Start < value);
		}

		private bool EqualsToOneOfEdges(float value, out bool includes)
		{
			includes = IncludesStart;

			if (Abs(value - Start) <= float.Epsilon) return true;

			includes = IncludesEnd;

			return Abs(value - End) <= float.Epsilon;
		}

		private bool IncludesInCaseOfPositiveLength(float value)
		{
			if (EqualsToOneOfEdges(value, out bool includes)) return includes;

			return !(value < Start) && !(End < value);
		}
	}
}
