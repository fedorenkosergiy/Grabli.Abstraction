using System;
using static UnityEngine.Mathf;

namespace Grabli.Abstraction
{
	[Serializable]
	public struct RangeFloatOpen
	{
		public EdgeFloat start;
		public bool direction;

		public float End => direction ? float.PositiveInfinity : float.NegativeInfinity;

		public RangeFloatOpen(EdgeFloat start, bool direction)
		{
			this.start = start;
			this.direction = direction;
		}

		public RangeFloatOpen(float value, bool included, bool direction) : this(new EdgeFloat(value, included),
																				 direction) { }

		public bool Includes(float value)
		{
			if (Approximately(start.value, value)) return start.included;
			if (start.value < value) return direction;

			return !direction;
		}

		public bool Includes(RangeFloatOpen value)
		{
			if (direction != value.direction) return false;

			if (Approximately(start.value, value.start.value)) return start.included || !value.start.included;

			if (start.value < value.start.value) return direction;

			return !direction;
		}

		public bool Includes(EdgeFloat edge)
		{
			return Includes(edge.value) || start.included == edge.included && Approximately(start.value, edge.value);
		}

		public bool Equals(RangeFloatOpen other) => start.Equals(other.start) && direction == other.direction;

		public override bool Equals(object obj) => obj is RangeFloatOpen other && Equals(other);

		public override int GetHashCode() => HashCode.Combine(start, direction);

		public static bool operator ==(RangeFloatOpen a, RangeFloatOpen b)
		{
			return a.start == b.start && a.direction == b.direction;
		}

		public static bool operator !=(RangeFloatOpen a, RangeFloatOpen b) => !(a == b);

		public static RangeFloatOpen operator +(RangeFloatOpen range, float value)
		{
			range.start += value;

			return range;
		}

		public static RangeFloatOpen operator -(RangeFloatOpen range, float value)
		{
			range.start -= value;

			return range;
		}
	}
}
