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

		public RangeFloat(float start, float length, EdgeInclusion edges)
		{
			bool startDirection = length > 0.0f;

			this.start =
			new RangeFloatOpen(start, startDirection, (edges & EdgeInclusion.Start) == EdgeInclusion.Start);

			end = new RangeFloatOpen(start + length, !startDirection, (edges & EdgeInclusion.End) == EdgeInclusion.End);
		}

		public bool Includes(float value) => start.Includes(value) && end.Includes(value);


		public bool Includes(RangeFloat value) => start.Includes(value.start) && end.Includes(value.end);

		public Vector2 MinMaxToVector2() => new Vector2(Min.point.x,  Max.point.x);

		public Vector2 StartEndToVector2() => new Vector2(start.point.x, end.point.x);

		public bool Equals(RangeFloat other) => start.Equals(other.start) && end.Equals(other.end);

		public override bool Equals(object obj) => obj is RangeFloat other && Equals(other);

		public override int GetHashCode() => HashCode.Combine(start, end);

		public static bool operator ==(RangeFloat a, RangeFloat b) { return a.start == b.start && a.end == b.end; }

		public static bool operator !=(RangeFloat a, RangeFloat b) { return !(a == b); }
	}
}
