using System.Windows.Forms;

namespace LiveSplit.Sheepo.UI
{
	public partial class SheepoMasterControl : UserControl
	{
		public SheepoMasterControl()
		{
			InitializeComponent();
		}

		public bool ShouldAutostart
		{
			get => autostartCheckbox.Checked;
			set => autostartCheckbox.Checked = value;
		}

		public SheepoSplitsControl SplitsControl => splitsControl;
	}
}
