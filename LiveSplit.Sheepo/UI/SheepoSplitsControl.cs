using System;
using System.Drawing;
using System.Windows.Forms;
using LiveSplit.Sheepo.Data;

namespace LiveSplit.Sheepo.UI
{
	public partial class SheepoSplitsControl : UserControl
	{
		public SheepoSplitsControl()
		{
			InitializeComponent();
		}

        private void addButton_Click(object sender, EventArgs e)
        {
			AddSplit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
	        var controls = splitsPanel.Controls;
	        var shouldClear = true;

	        // It seems annoying to prompt the player to clear splits when there's only one.
	        if (controls.Count > 1)
	        {
		        var result = MessageBox.Show("Are you sure you want to clear your splits?", "Clear splits?",
			        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		        shouldClear = result == DialogResult.Yes;
	        }

	        if (shouldClear)
	        {
		        splitsPanel.Controls.Clear();

		        RefreshSplitCount();
	        }
        }

        public void Refresh(Split[] splits)
        {
        }

        public Split[] ExtractSplits()
        {
	        var controls = splitsPanel.Controls;

	        if (controls.Count == 0)
	        {
		        return null;
	        }

	        var splits = new Split[controls.Count];

	        for (int i = 0; i < controls.Count; i++)
	        {
		        splits[i] = ((SheepoSplitControl)controls[i]).ExtractSplit();
	        }

	        return splits;
        }

        public void AddSplit(Split split = null)
        {
			var controls = splitsPanel.Controls;
			var control = new SheepoSplitControl(this, controls.Count);

			if (split != null)
			{
				control.Refresh(split);
			}

			var y = controls.Count == 0 ? 0 : controls[controls.Count - 1].Bottom;

			control.Location = new Point(0, y);
			controls.Add(control);
			control.Up.Enabled = controls.Count > 1;

			RefreshSplitCount();
        }

        public void RemoveSplit(int index)
        {
	        // This function is only called from split controls, which means the index is guaranteed to be valid.
	        var controls = splitsPanel.Controls;
	        var split = (SheepoSplitsControl)controls[index];
	        var height = split.Height;

	        controls.RemoveAt(index);

	        for (int i = index; i < controls.Count; i++)
	        {
		        var control = (SheepoSplitControl)controls[i];
		        var point = control.Location;

		        point.Y -= height;
		        control.Location = point;
		        control.Index--;
	        }

	        RefreshSplitCount();
        }

        public void MoveUp(int index)
        {
	        Swap(index, index - 1);
        }

        public void MoveDown(int index)
        {
	        Swap(index, index + 1);
        }

        private void Swap(int i0, int i1)
        {
	        var controls = splitsPanel.Controls;
	        var s0 = (SheepoSplitControl)controls[i0];
	        var s1 = (SheepoSplitControl)controls[i1];
	        var temp = s0.Location;
	        s0.Location = s1.Location;
	        s1.Location = temp;

	        controls.SetChildIndex(s0, i1);
	        controls.SetChildIndex(s1, i0);

	        s0.Index = i1;
	        s1.Index = i0;

	        ToggleButtons(s0);
	        ToggleButtons(s1);
        }

        private void ToggleButtons(SheepoSplitControl split)
        {
	        split.Up.Enabled = split.Index > 0;
	        split.Down.Enabled = split.Index < splitsPanel.Controls.Count - 1;
        }

		private void RefreshSplitCount()
		{
			var count = splitsPanel.Controls.Count;

			splitCountLabel.Text = count + " split" + (count != 1 ? "s" : "");
			clearButton.Enabled = count > 0;
		}
	}
}
