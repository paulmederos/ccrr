namespace WordCloud
{
	partial class TestForm
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
            this.testBtn = new System.Windows.Forms.Button();
            this.testBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(13, 12);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "TEST";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(13, 47);
            this.testBox.Multiline = true;
            this.testBox.Name = "testBox";
            this.testBox.ReadOnly = true;
            this.testBox.Size = new System.Drawing.Size(275, 425);
            this.testBox.TabIndex = 1;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(213, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 484);
            this.Controls.Add(this.search);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.testBtn);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button testBtn;
		private System.Windows.Forms.TextBox testBox;
        private System.Windows.Forms.Button search;
	}
}

