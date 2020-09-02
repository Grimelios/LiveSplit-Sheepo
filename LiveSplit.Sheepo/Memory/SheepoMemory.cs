using System;
using System.Diagnostics;

namespace LiveSplit.Sheepo.Memory
{
	public class SheepoMemory
	{
		private SheepoPointers pointers;
		private Process process;
		private IntPtr handle;

		public bool IsProcessHooked { get; private set; }

		public bool Hook()
		{
			if (IsProcessHooked)
			{
				if (process.HasExited)
				{
					IsProcessHooked = false;
					process = null;

					return false;
				}

				pointers.Refresh();

				return true;
			}

			var processes = Process.GetProcessesByName("Sheepo");

			if (processes.Length > 0)
			{
				process = processes[0];

				if (process.HasExited)
				{
					return false;
				}

				// Item trackers are created below (or left as null if not needed).
				handle = process.Handle;
				pointers = new SheepoPointers(process);
				IsProcessHooked = true;
			}

			return IsProcessHooked;
		}
	}
}
