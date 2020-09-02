using System;
using System.Windows.Forms;
using LiveSplit.Sheepo.Data;

namespace LiveSplit.Sheepo.UI
{
	public partial class SheepoSplitControl : UserControl
	{
		private SheepoSplitsControl parent;

		public SheepoSplitControl(SheepoSplitsControl parent, int index)
		{
			this.parent = parent;

			Index = index;

			InitializeComponent();
		}

		public int Index { get; set; }

		public Button Up => upButton;
		public Button Down => downButton;

        private void deleteButton_Click(object sender, EventArgs e)
        {
	        parent.RemoveSplit(Index);
        }

		private void upButton_Click(object sender, EventArgs e)
		{
			parent.MoveUp(Index);
		}

		private void downButton_Click(object sender, EventArgs e)
		{
			parent.MoveDown(Index);
		}

		public void Refresh(Split split)
		{
		}

		public Split ExtractSplit()
		{
			return null;
		}
	}
}
