using JetBrains.Annotations;
using System;

namespace Grabli.Abstraction
{
	[AttributeUsage(AttributeTargets.Class |
					AttributeTargets.Struct |
					AttributeTargets.Interface |
					AttributeTargets.Enum |
					AttributeTargets.Field |
					AttributeTargets.Property)]
	[PublicAPI]
	public class LocalizationKeyAttribute : Attribute
	{
		public readonly string Data;

		public LocalizationKeyAttribute() : this(null) { }

		public LocalizationKeyAttribute(string data) { Data = data; }
	}
}
