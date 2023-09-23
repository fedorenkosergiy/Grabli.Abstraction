using JetBrains.Annotations;
using System;
using static System.Math;

namespace Grabli.Abstraction
{
	[PublicAPI][Serializable]
	public partial struct RangeFloat
	{
		public float start;
		public float length;
		public EdgeInclusion edges;

		public bool IncludesStart => (edges & EdgeInclusion.Start) == EdgeInclusion.Start;

		public bool IncludesEnd => (edges & EdgeInclusion.End) == EdgeInclusion.End;

		public float End => start + length;

		public RangeFloat(float start, float length, EdgeInclusion edges)
		{
			this.start = start;
			this.length = length;
			this.edges = edges;
		}

		public bool Includes(float value)
		{
			return length switch
			{
			> 0.0f => IncludesInCaseOfPositiveLength(value),
			< 0.0f => IncludesInCaseOfNegativeLength(value),
			_ => EqualsToOneOfEdges(value, out bool includes) && includes
			};
		}

		private bool IncludesInCaseOfNegativeLength(float value)
		{
			if (EqualsToOneOfEdges(value, out bool includes)) return includes;

			return !(value < End) && !(start < value);
		}

		private bool EqualsToOneOfEdges(float value, out bool includes)
		{
			includes = IncludesStart;

			if (Abs(value - start) <= float.Epsilon) return true;

			includes = IncludesEnd;

			return Abs(value - End) <= float.Epsilon;
		}

		private bool IncludesInCaseOfPositiveLength(float value)
		{
			if (EqualsToOneOfEdges(value, out bool includes)) return includes;

			return !(value < start) && !(End < value);
		}
	}
}
