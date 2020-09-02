namespace LiveSplit.Sheepo.UI
{
	partial class SheepoMasterControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.autostartCheckbox = new System.Windows.Forms.CheckBox();
			this.splitsControl = new LiveSplit.Sheepo.UI.SheepoSplitsControl();
			this.SuspendLayout();
			// 
			// autostartCheckbox
			// 
			this.autostartCheckbox.AutoSize = true;
			this.autostartCheckbox.Checked = true;
			this.autostartCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.autostartCheckbox.Location = new System.Drawing.Point(4, 4);
			this.autostartCheckbox.Name = "autostartCheckbox";
			this.autostartCheckbox.Size = new System.Drawing.Size(137, 17);
			this.autostartCheckbox.TabIndex = 0;
			this.autostartCheckbox.Text = "Start timer automatically";
			this.autostartCheckbox.UseVisualStyleBackColor = true;
			// 
			// splitsControl
			// 
			this.splitsControl.Location = new System.Drawing.Point(4, 28);
			this.splitsControl.Name = "splitsControl";
			this.splitsControl.Size = new System.Drawing.Size(461, 490);
			this.splitsControl.TabIndex = 1;
			// 
			// SheepoMasterControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitsControl);
			this.Controls.Add(this.autostartCheckbox);
			this.Name = "SheepoMasterControl";
			this.Size = new System.Drawing.Size(468, 524);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.CheckBox autostartCheckbox;
        private SheepoSplitsControl splitsControl;
    }
}
