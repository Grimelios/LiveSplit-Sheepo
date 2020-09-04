using System;
using System.Text;
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
			var type = split.Type;

			if (type == SplitTypes.Unassigned)
			{
				return;
			}

			splitTypeDropdown.SelectedIndex = (int)type;

			var details = detailsPanel.Controls;

			if (details.Count > 0)
			{
				var first = details[0];

				if (first is TextBox textbox)
				{
					textbox.Text = split.Data >= 0 ? split.Data + "" : "";
				}
				else
				{
					((ComboBox)first).SelectedIndex = split.Data;
				}
			}
		}

		public Split ExtractSplit()
		{
			var type = (SplitTypes)splitTypeDropdown.SelectedIndex;
			var details = detailsPanel.Controls;
			var data = -1;

			if (details.Count > 0)
			{
				if (details[0] is TextBox textbox)
				{
					data = int.Parse(textbox.Text);
				}
				else
				{
					data = ((ComboBox)details[0]).SelectedIndex;
				}
			}

			return new Split(type, data);
		}

		private void splitTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			var control = GetDetails((SplitTypes)splitTypeDropdown.SelectedIndex);
			var details = detailsPanel.Controls;
			details.Clear();

			if (control != null)
			{
				details.Add(control);
			}
		}

		private Control GetDetails(SplitTypes type)
		{
			switch (type)
			{
				case SplitTypes.Egg:
					var dropdown = new ComboBox();
					dropdown.Items.AddRange(Enum.GetNames(typeof(Eggs)));

					return dropdown;

				case SplitTypes.Feather:
					var textbox = new TextBox
					{
						Height = 21,
						TextAlign = HorizontalAlignment.Center
					};

					// See https://stackoverflow.com/q/463299/7281613 (these events are also copied from the Dark Souls
					// autosplitter).
					textbox.KeyPress += (sender, args) =>
					{
						char c = args.KeyChar;

						// See http://www.asciitable.com/ as well. The idea here is to accept all control keys (such as
						// Ctrl + V) while still excluding letters and punctuation.
						if (c >= '!' && c <= '~' && !char.IsDigit(args.KeyChar))
						{
							args.Handled = true;
						}
					};

					textbox.KeyDown += (sender, args) =>
					{
						// Pressing escape removes focus from the textbox.
						if (args.KeyCode == Keys.Escape)
						{
							ParentForm.Controls[0].Focus();
						}
					};

					textbox.TextChanged += (sender, args) =>
					{
						string text = textbox.Text;

						if (text.Length == 0 || int.TryParse(text, out _))
						{
							return;
						}

						// It's possible to paste a non-integer into the textbox. If the above check fails, all non-
						// digits are stripped from the pasted value.
						var builder = new StringBuilder();

						foreach (char c in text)
						{
							if (char.IsDigit(c))
							{
								builder.Append(c);
							}
						}

						// This actually causes the TextChanged event to be triggered again, but the function returns
						// immediately due to the checks above.
						textbox.Text = builder.ToString();
					};

					textbox.Enter += (sender, args) =>
					{
						// See https://stackoverflow.com/a/6857301/7281613. This causes all text to be selected after
						// the click is processed.
						BeginInvoke((Action)textbox.SelectAll);
					};

					return textbox;
			}

			return null;
		}
	}
}
