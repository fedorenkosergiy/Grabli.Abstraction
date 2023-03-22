using JetBrains.Annotations;

namespace Grabli.Abstraction
{
	public static partial class Constant
	{
		[PublicAPI]
		public static class FileExtension
		{
			public const string Json = "json";
			public const string Asset = "asset";
			public const string Tmp = "tmp";
			public const string Bak = "bak";
			public const string Cs = "cs";

			[PublicAPI]
			public static class Dot
			{
				public const string Json = "." + FileExtension.Json;
				public const string Asset = "." + FileExtension.Asset;
				public const string Tmp = "." + FileExtension.Tmp;
				public const string Bak = "." + FileExtension.Bak;
				public const string Cs = "." + FileExtension.Cs;
			}

			[PublicAPI]
			public static class Star
			{
				public const string Json = "*" + FileExtension.Json;
				public const string Asset = "*" + FileExtension.Asset;
				public const string Tmp = "*" + FileExtension.Tmp;
				public const string Bak = "*" + FileExtension.Bak;
				public const string Cs = "*" + FileExtension.Cs;

				[PublicAPI]
				public static class Dot
				{
					public const string Json = "*" + FileExtension.Dot.Json;
					public const string Asset = "*" + FileExtension.Dot.Asset;
					public const string Tmp = "*" + FileExtension.Dot.Tmp;
					public const string Bak = "*" + FileExtension.Dot.Bak;
					public const string Cs = "*" + FileExtension.Dot.Cs;
				}
			}
		}
	}
}
