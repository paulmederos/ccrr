namespace WordCloud
{
    partial class DocumentViewUI
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
        Document doc1, doc2;
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.documentListBox = new System.Windows.Forms.ListBox();
            this.documentPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.documentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.documentListBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 523);
            this.panel1.TabIndex = 0;
            // 
            // documentListBox
            // 
            this.documentListBox.FormattingEnabled = true;
            //this.documentListBox.Items.AddRange(GUI.curSearchTerm.fileNames);
            this.documentListBox.Location = new System.Drawing.Point(3, 16);
            this.documentListBox.Name = "documentListBox";
            this.documentListBox.Size = new System.Drawing.Size(150, 199);
            this.documentListBox.TabIndex = 0;
            // 
            // documentPanel
            // 
            this.documentPanel.Controls.Add(this.textBox1);
            this.documentPanel.Location = new System.Drawing.Point(174, 12);
            this.documentPanel.Name = "documentPanel";
            this.documentPanel.Size = new System.Drawing.Size(449, 523);
            this.documentPanel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(0, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(448, 507);
            this.textBox1.TabIndex = 0;
            // 
            // DocumentViewUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 547);
            this.Controls.Add(this.documentPanel);
            this.Controls.Add(this.panel1);
            this.Name = "DocumentViewUI";
            this.Text = "DocumentViewUI";
            this.panel1.ResumeLayout(false);
            this.documentPanel.ResumeLayout(false);
            this.documentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox documentListBox;
        private System.Windows.Forms.Panel documentPanel;
        private System.Windows.Forms.TextBox textBox1;
    }
}