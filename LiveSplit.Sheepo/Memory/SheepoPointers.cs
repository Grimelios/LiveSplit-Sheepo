using System;
using System.Diagnostics;

namespace LiveSplit.Sheepo.Memory
{
	public class SheepoPointers
	{
		private IntPtr handle;

		public SheepoPointers(Process process)
		{
			handle = process.Handle;
		}

		public void Refresh()
		{
		}
	}
}
