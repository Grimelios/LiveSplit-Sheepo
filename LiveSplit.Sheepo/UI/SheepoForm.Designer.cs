namespace LiveSplit.Sheepo.UI
{
	partial class SheepoForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.masterControl = new LiveSplit.Sheepo.UI.SheepoMasterControl();
			this.SuspendLayout();
			// 
			// masterControl
			// 
			this.masterControl.Location = new System.Drawing.Point(13, 13);
			this.masterControl.Name = "masterControl";
			this.masterControl.ShouldAutostart = true;
			this.masterControl.Size = new System.Drawing.Size(453, 483);
			this.masterControl.TabIndex = 0;
			// 
			// SheepoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 508);
			this.Controls.Add(this.masterControl);
			this.Name = "SheepoForm";
			this.Text = "Sheepo UI Form";
			this.ResumeLayout(false);

		}

        #endregion

        private SheepoMasterControl masterControl;
    }
}