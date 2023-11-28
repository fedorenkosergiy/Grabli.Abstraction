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
			public const string Bytes = "bytes";
			public const string Cs = "cs";
			public const string Db = "db";
			public const string Dll = "dll";
			public const string Fbx = "fbx";
			public const string Json = "json";
			public const string Png = "png";
			public const string Prefab = "prefab";
			public const string Tmp = "tmp";
			public const string Txt = "txt";
			public const string Unity = "unity";

			[PublicAPI]
			public static class Dot
			{
				public const string Asset = "." + FileExtension.Asset;
				public const string Bak = "." + FileExtension.Bak;
				public const string Bytes = "." + FileExtension.Bytes;
				public const string Cs = "." + FileExtension.Cs;
				public const string Db = "." + FileExtension.Db;
				public const string Dll = "." + FileExtension.Dll;
				public const string Fbx = "." + FileExtension.Fbx;
				public const string Json = "." + FileExtension.Json;
				public const string Png = "." + FileExtension.Png;
				public const string Prefab = "." + FileExtension.Prefab;
				public const string Tmp = "." + FileExtension.Tmp;
				public const string Txt = "." + FileExtension.Txt;
				public const string Unity = "." + FileExtension.Unity;
			}

			[PublicAPI]
			public static class Star
			{
				public const string Asset = "*" + FileExtension.Asset;
				public const string Bak = "*" + FileExtension.Bak;
				public const string Bytes = "*" + FileExtension.Bytes;
				public const string Cs = "*" + FileExtension.Cs;
				public const string Db = "*" + FileExtension.Db;
				public const string Dll = "*" + FileExtension.Dll;
				public const string Fbx = "*" + FileExtension.Fbx;
				public const string Json = "*" + FileExtension.Json;
				public const string Png = "*" + FileExtension.Png;
				public const string Prefab = "*" + FileExtension.Prefab;
				public const string Tmp = "*" + FileExtension.Tmp;
				public const string Txt = "*" + FileExtension.Txt;
				public const string Unity = "*" + FileExtension.Unity;

				[PublicAPI]
				public static class Dot
				{
					public const string Asset = "*" + FileExtension.Dot.Asset;
					public const string Bak = "*" + FileExtension.Dot.Bak;
					public const string Bytes = "*" + FileExtension.Dot.Bytes;
					public const string Cs = "*" + FileExtension.Dot.Cs;
					public const string Db = "*" + FileExtension.Dot.Db;
					public const string Dll = "*" + FileExtension.Dot.Dll;
					public const string Fbx = "*" + FileExtension.Dot.Fbx;
					public const string Json = "*" + FileExtension.Dot.Json;
					public const string Png = "*" + FileExtension.Dot.Png;
					public const string Prefab = "*" + FileExtension.Dot.Prefab;
					public const string Tmp = "*" + FileExtension.Dot.Tmp;
					public const string Txt = "*" + FileExtension.Dot.Txt;
					public const string Unity = "*" + FileExtension.Dot.Unity;
				}
			}
		}
	}
}
