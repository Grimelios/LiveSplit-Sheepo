namespace LiveSplit.Sheepo.UI
{
	partial class SheepoSplitControl
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
			this.splitTypeDropdown = new System.Windows.Forms.ComboBox();
			this.deleteButton = new System.Windows.Forms.Button();
			this.upButton = new System.Windows.Forms.Button();
			this.downButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// splitTypeDropdown
			// 
			this.splitTypeDropdown.FormattingEnabled = true;
			this.splitTypeDropdown.Items.AddRange(new object[] {
            "Egg",
            "End",
            "Start"});
			this.splitTypeDropdown.Location = new System.Drawing.Point(4, 4);
			this.splitTypeDropdown.Name = "splitTypeDropdown";
			this.splitTypeDropdown.Size = new System.Drawing.Size(121, 21);
			this.splitTypeDropdown.TabIndex = 0;
			// 
			// deleteButton
			// 
			this.deleteButton.Image = global::LiveSplit.Sheepo.Resources.Delete;
			this.deleteButton.Location = new System.Drawing.Point(372, 3);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(22, 22);
			this.deleteButton.TabIndex = 1;
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// upButton
			// 
			this.upButton.Image = global::LiveSplit.Sheepo.Resources.Up;
			this.upButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.upButton.Location = new System.Drawing.Point(394, 3);
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(22, 22);
			this.upButton.TabIndex = 2;
			this.upButton.UseVisualStyleBackColor = true;
			this.upButton.Click += new System.EventHandler(this.upButton_Click);
			// 
			// downButton
			// 
			this.downButton.Enabled = false;
			this.downButton.Image = global::LiveSplit.Sheepo.Resources.Down;
			this.downButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.downButton.Location = new System.Drawing.Point(416, 3);
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(22, 22);
			this.downButton.TabIndex = 3;
			this.downButton.UseVisualStyleBackColor = true;
			this.downButton.Click += new System.EventHandler(this.downButton_Click);
			// 
			// SheepoSplitControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.downButton);
			this.Controls.Add(this.upButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.splitTypeDropdown);
			this.Name = "SheepoSplitControl";
			this.Size = new System.Drawing.Size(437, 27);
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.ComboBox splitTypeDropdown;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
    }
}
