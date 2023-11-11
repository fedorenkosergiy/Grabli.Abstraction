using System;
using System.Diagnostics;
using static UnityEngine.Mathf;

namespace Grabli.Abstraction
{
	[Serializable]
	[DebuggerDisplay("{" + nameof(DebuggerText) + "}")]
	public struct RangeFloatOpen
	{
		public Vector1 point;
		public bool included;

		private string DebuggerText
		{
			get
			{
				if (point.direction) return (included ? "[" : "(") + point.x;

				return point.x + (included ? "]" : ")");
			}
		}

		public RangeFloatOpen(float x, bool direction, bool included)
		{
			point = new Vector1(x, direction);
			this.included = included;
		}

		public bool Includes(float value)
		{
			if (Approximately(point.x, value)) return included;
			if (point.x < value) return point.direction;

			return !point.direction;
		}

		public bool Includes(RangeFloatOpen value)
		{
			if (point.direction != value.point.direction) return false;

			if (Approximately(point.x, value.point.x)) return included || !value.included;

			if (point.x < value.point.x) return point.direction;

			return !point.direction;
		}

		public bool Equals(RangeFloatOpen other) => point.Equals(other.point) && included == other.included;

		public override bool Equals(object obj) => obj is RangeFloatOpen other && Equals(other);

		public override int GetHashCode() => HashCode.Combine(point, included);

		public static bool operator ==(RangeFloatOpen a, RangeFloatOpen b)
		{
			return a.point == b.point && a.included == b.included;
		}

		public static bool operator !=(RangeFloatOpen a, RangeFloatOpen b) => !(a == b);

		public static RangeFloatOpen operator +(RangeFloatOpen range, float value)
		{
			range.point += value;

			return range;
		}

		public static RangeFloatOpen operator -(RangeFloatOpen range, float value)
		{
			range.point -= value;

			return range;
		}
	}
}
