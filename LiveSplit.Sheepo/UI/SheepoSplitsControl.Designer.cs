namespace LiveSplit.Sheepo.UI
{
	partial class SheepoSplitsControl
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
			this.addButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.splitCountLabel = new System.Windows.Forms.Label();
			this.splitsPanel = new System.Windows.Forms.Panel();
			this.splitTypeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Image = global::LiveSplit.Sheepo.Resources.Add;
			this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addButton.Location = new System.Drawing.Point(12, 7);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(71, 24);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "Add Split";
			this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Image = global::LiveSplit.Sheepo.Resources.Clear;
			this.clearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clearButton.Location = new System.Drawing.Point(84, 7);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(82, 24);
			this.clearButton.TabIndex = 1;
			this.clearButton.Text = "Clear Splits";
			this.clearButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// splitCountLabel
			// 
			this.splitCountLabel.AutoSize = true;
			this.splitCountLabel.Location = new System.Drawing.Point(173, 13);
			this.splitCountLabel.Name = "splitCountLabel";
			this.splitCountLabel.Size = new System.Drawing.Size(39, 13);
			this.splitCountLabel.TabIndex = 2;
			this.splitCountLabel.Text = "0 splits";
			// 
			// splitsPanel
			// 
			this.splitsPanel.Location = new System.Drawing.Point(1, 56);
			this.splitsPanel.Name = "splitsPanel";
			this.splitsPanel.Size = new System.Drawing.Size(458, 431);
			this.splitsPanel.TabIndex = 3;
			// 
			// splitTypeLabel
			// 
			this.splitTypeLabel.AutoSize = true;
			this.splitTypeLabel.Location = new System.Drawing.Point(13, 39);
			this.splitTypeLabel.Name = "splitTypeLabel";
			this.splitTypeLabel.Size = new System.Drawing.Size(31, 13);
			this.splitTypeLabel.TabIndex = 4;
			this.splitTypeLabel.Text = "Type";
			// 
			// SheepoSplitsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitTypeLabel);
			this.Controls.Add(this.splitsPanel);
			this.Controls.Add(this.splitCountLabel);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.addButton);
			this.Name = "SheepoSplitsControl";
			this.Size = new System.Drawing.Size(461, 490);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label splitCountLabel;
        private System.Windows.Forms.Panel splitsPanel;
        private System.Windows.Forms.Label splitTypeLabel;
    }
}
