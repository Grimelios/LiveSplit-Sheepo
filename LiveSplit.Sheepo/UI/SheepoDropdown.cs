using System.Drawing;
using System.Windows.Forms;

namespace LiveSplit.Sheepo.UI
{
	public class SheepoDropdown : ComboBox
	{
		private static readonly Color DefaultColor = Color.White;
		private static readonly Color UnfinishedColor = Color.PaleVioletRed;

		public SheepoDropdown()
		{
			DropDownStyle = ComboBoxStyle.DropDownList;
			DrawMode = DrawMode.OwnerDrawFixed;
		}
		
		public string Prompt { get; set; }

		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			const int UnfinishedTextColor = 80;

			var g = e.Graphics;
			var textColor = Color.Black;
			var bounds = e.Bounds;
			var offsetX = -1;
			var offsetY = 1;
			
			string value;

			if (e.Index == -1)
			{
				value = Prompt;

				// Enabled splits with a -1 index have a red-tinted background. On that background, grey text is hard
				// to read.
				textColor = !Enabled
					? SystemColors.ButtonShadow
					: Color.FromArgb(255, UnfinishedTextColor, UnfinishedTextColor, UnfinishedTextColor);
			}
			else
			{
				value = Items[e.Index].ToString();

				g.FillRectangle(value.Length > 0 && (e.State & DrawItemState.Selected) > 0
					? new SolidBrush(Color.LimeGreen)
					: new SolidBrush(Color.White), bounds);
			}

			// See http://blog.stevex.net/rendering-text-using-the-net-framework/.
			TextRenderer.DrawText(g, value, Font, new Point(bounds.X + offsetX, bounds.Y + offsetY), textColor);
		}
	}
}
