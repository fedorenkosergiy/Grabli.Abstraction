using System;
using static UnityEngine.Mathf;

namespace Grabli.Abstraction
{
	[Serializable]
	public struct EdgeFloat
	{
		public float value;
		public bool included;

		public EdgeFloat(float value, bool included)
		{
			this.value = value;
			this.included = included;
		}

		public bool Equals(EdgeFloat other) => value.Equals(other.value) && included == other.included;

		public override bool Equals(object obj) => obj is EdgeFloat other && Equals(other);

		public override int GetHashCode() => HashCode.Combine(value, included);

		public static EdgeFloat operator +(EdgeFloat edge, float offset)
		{
			edge.value += offset;

			return edge;
		}

		public static EdgeFloat operator -(EdgeFloat edge, float diff)
		{
			edge.value -= diff;

			return edge;
		}

		public static bool operator ==(EdgeFloat a, EdgeFloat b)
		{
			return a.included == b.included && Approximately(a.value, b.value);
		}

		public static bool operator !=(EdgeFloat a, EdgeFloat b) { return !(a == b); }
	}
}
