using System.Threading;

namespace LiveSplit.Sheepo
{
	public static class SheepoTester
	{
		private const int Tick = 30;

		public static void Main(string[] args)
		{
			const bool FormTesting = false;

			if (FormTesting)
			{
			}
			else
			{
				var component = new SheepoComponent();

				while (true)
				{
					component.Refresh();

					Thread.Sleep((int)(1000f / Tick));
				}
			}
		}
	}
}
