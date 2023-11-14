using JetBrains.Annotations;
using System;
using System.Diagnostics;
using UnityEngine;

namespace Grabli.Abstraction
{
	[PublicAPI]
	[Serializable]
	[DebuggerDisplay("{" + nameof(Min) + "};{" + nameof(Max) + "}")]
	public partial struct RangeFloatClosed
	{
		public EdgeFloat start;
		public EdgeFloat end;

		public float Length => end.value - start.value;

		public EdgeFloat Min => Length > 0.0f ? start : end;

		public EdgeFloat Max => Length > 0.0f ? end : start;

		private RangeFloatOpen StartAsRange => new RangeFloatOpen(start, Length >= 0.0f);

		private RangeFloatOpen EndAsRange => new RangeFloatOpen(end, Length < 0.0f);

		public RangeFloatClosed(Vector2 startAndEnd) : this(startAndEnd, EdgeInclusion.Both) { }

		public RangeFloatClosed(Vector2 startAndEnd, EdgeInclusion edges) : this(startAndEnd.x,
																				 startAndEnd.y - startAndEnd.x,
																				 edges) { }

		public RangeFloatClosed(float start, float length, EdgeInclusion edges) :
		this(new EdgeFloat(start, (edges & EdgeInclusion.Start) == EdgeInclusion.Start),
			 new EdgeFloat(start + length, (edges & EdgeInclusion.End) == EdgeInclusion.End)) { }


		private RangeFloatClosed(EdgeFloat start, EdgeFloat end)
		{
			this.start = start;
			this.end = end;
		}

		public bool Includes(float value) => StartAsRange.Includes(value) && EndAsRange.Includes(value);

		public bool Includes(RangeFloatClosed value) =>
		StartAsRange.Includes(value.start) && EndAsRange.Includes(value.end);

		public Vector2 MinMaxToVector2() => new Vector2(Min.value, Max.value);

		public Vector2 StartEndToVector2() => new Vector2(start.value, end.value);

		public bool Equals(RangeFloatClosed other) => start.Equals(other.start) && end.Equals(other.end);

		public override bool Equals(object obj) => obj is RangeFloatClosed other && Equals(other);

		public override int GetHashCode() => HashCode.Combine(start, end);

		public static bool operator ==(RangeFloatClosed a, RangeFloatClosed b)
		{
			return a.start == b.start && a.end == b.end;
		}

		public static bool operator !=(RangeFloatClosed a, RangeFloatClosed b) { return !(a == b); }
	}
}
