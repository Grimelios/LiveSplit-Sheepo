using System;
using LiveSplit.Model;
using LiveSplit.UI.Components;

namespace LiveSplit.Sheepo
{
	public class SheepoFactory : IComponentFactory
	{
		public string ComponentName => "Sheepo Autosplitter v" + Version;
		public string Description => "Configurable autosplitter for Sheepo.";
		public string UpdateName => ComponentName;
		public string UpdateURL => "https://raw.githubusercontent.com/Grimelios/LiveSplit.Sheepo/master/";
		public string XMLURL => UpdateURL + "Components/Updates.xml";

		public Version Version => Utilities.GetVersion();

		public ComponentCategory Category => ComponentCategory.Control;

		public IComponent Create(LiveSplitState state)
		{
			return new SheepoComponent();
		}
	}
}
