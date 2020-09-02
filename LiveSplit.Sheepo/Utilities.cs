using System;
using System.Reflection;

namespace LiveSplit.Sheepo
{
	public static class Utilities
	{
		public static Version GetVersion()
		{
			var version = Assembly.GetExecutingAssembly().GetName().Version;

			return Version.Parse($"{version.Major}.{version.Minor}.{version.Build}");
		}
	}
}
