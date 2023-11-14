using JetBrains.Annotations;
using System;
using System.Diagnostics;
using UnityEngine;

namespace Grabli.Abstraction
{
	[PublicAPI]
	[Serializable]
	[DebuggerDisplay("{" + nameof(Min) + "};{" + nameof(Max) + "}")]
	public partial struct RangeFloat
	{
		public RangeFloatOpen start;
		public RangeFloatOpen end;

		public float Length => end.point.x - start.point.x;

		public RangeFloatOpen Min => Length > 0.0f ? start : end;

		public RangeFloatOpen Max => Length > 0.0f ? end : start;

		public bool IsClosed => Min.Includes(Max.point.x) && Max.Includes(Min.point.x);

		public RangeFloat(Vector2 startAndEnd) : this(startAndEnd, EdgeInclusion.Both) { }

		public RangeFloat(Vector2 startAndEnd, EdgeInclusion edges) : this(startAndEnd.x,
																		   startAndEnd.y - startAndEnd.x,
																		   edges) { }

		public RangeFloat(float start, float length, EdgeInclusion edges) :
		this(new RangeFloatOpen(start, length >= 0.0f, (edges & EdgeInclusion.Start) == EdgeInclusion.Start),
			 new RangeFloatOpen(start + length, length < 0.0f, (edges & EdgeInclusion.End) == EdgeInclusion.End)) { }


		public RangeFloat(RangeFloatOpen start, RangeFloatOpen end)
		{
			this.start = start;
			this.end = end;
		}

		public bool Includes(float value) => start.Includes(value) && end.Includes(value);

		public bool Includes(RangeFloat value) => start.Includes(value.start) && end.Includes(value.end);

		public Vector2 MinMaxToVector2() => new Vector2(Min.point.x, Max.point.x);

		public Vector2 StartEndToVector2() => new Vector2(start.point.x, end.point.x);

		public bool Equals(RangeFloat other) => start.Equals(other.start) && end.Equals(other.end);

		public override bool Equals(object obj) => obj is RangeFloat other && Equals(other);

		public override int GetHashCode() => HashCode.Combine(start, end);

		public static bool operator ==(RangeFloat a, RangeFloat b) { return a.start == b.start && a.end == b.end; }

		public static bool operator !=(RangeFloat a, RangeFloat b) { return !(a == b); }
	}
}
