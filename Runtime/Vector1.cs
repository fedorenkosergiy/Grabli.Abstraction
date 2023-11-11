using System;
using static System.Math;

namespace Grabli.Abstraction
{
	[Serializable]
	public struct Vector1
	{
		public float x;
		public bool direction;

		public Vector1(float x, bool direction)
		{
			this.x = x;
			this.direction = direction;
		}

		public bool Equals(Vector1 other) => x.Equals(other.x) && direction == other.direction;

		public override bool Equals(object obj) => obj is Vector1 other && Equals(other);

		public override int GetHashCode() => HashCode.Combine(x, direction);

		public static bool operator ==(Vector1 a, Vector1 b)
		{
			return Abs(a.x - b.x) < float.Epsilon && a.direction == b.direction;
		}

		public static bool operator !=(Vector1 a, Vector1 b) { return !(a == b); }

		public static Vector1 operator +(Vector1 vector, float value)
		{
			vector.x += value;

			return vector;
		}

		public static Vector1 operator -(Vector1 vector, float value)
		{
			vector.x -= value;

			return vector;
		}
	}
}
