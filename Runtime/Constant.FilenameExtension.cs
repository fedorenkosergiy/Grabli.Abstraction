using JetBrains.Annotations;

namespace Grabli.Abstraction
{
	public static partial class Constant
	{
		[PublicAPI]
		public static class FileExtension
		{
			public const string Asset = "asset";
			public const string Bak = "bak";
			public const string Cs = "cs";
			public const string Db = "db";
			public const string Json = "json";
			public const string Prefab = "prefab";
			public const string Tmp = "tmp";

			[PublicAPI]
			public static class Dot
			{
				public const string Asset = "." + FileExtension.Asset;
				public const string Bak = "." + FileExtension.Bak;
				public const string Cs = "." + FileExtension.Cs;
				public const string Db = "." + FileExtension.Db;
				public const string Json = "." + FileExtension.Json;
				public const string Prefab = "." + FileExtension.Prefab;
				public const string Tmp = "." + FileExtension.Tmp;
			}

			[PublicAPI]
			public static class Star
			{
				public const string Asset = "*" + FileExtension.Asset;
				public const string Bak = "*" + FileExtension.Bak;
				public const string Cs = "*" + FileExtension.Cs;
				public const string Db = "*" + FileExtension.Db;
				public const string Json = "*" + FileExtension.Json;
				public const string Prefab = "*" + FileExtension.Prefab;
				public const string Tmp = "*" + FileExtension.Tmp;

				[PublicAPI]
				public static class Dot
				{
					public const string Asset = "*" + FileExtension.Dot.Asset;
					public const string Bak = "*" + FileExtension.Dot.Bak;
					public const string Cs = "*" + FileExtension.Dot.Cs;
					public const string Db = "*" + FileExtension.Dot.Db;
					public const string Json = "*" + FileExtension.Dot.Json;
					public const string Prefab = "*" + FileExtension.Dot.Prefab;
					public const string Tmp = "*" + FileExtension.Dot.Tmp;
				}
			}
		}
	}
}
