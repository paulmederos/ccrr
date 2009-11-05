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
            this.label1 = new System.Windows.Forms.Label();
            this.entityLabel = new System.Windows.Forms.Label();
            this.documentListBox = new System.Windows.Forms.ListBox();
            this.documentPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.documentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.entityLabel);
            this.panel1.Controls.Add(this.documentListBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 523);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documents";
            // 
            // entityLabel
            // 
            this.entityLabel.AutoSize = true;
            this.entityLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityLabel.Location = new System.Drawing.Point(13, 10);
            this.entityLabel.Name = "entityLabel";
            this.entityLabel.Size = new System.Drawing.Size(90, 16);
            this.entityLabel.TabIndex = 1;
            this.entityLabel.Text = "Documents";
            // 
            // documentListBox
            // 
            this.documentListBox.FormattingEnabled = true;
            this.documentListBox.Location = new System.Drawing.Point(3, 36);
            this.documentListBox.Name = "documentListBox";
            this.documentListBox.Size = new System.Drawing.Size(150, 199);
            this.documentListBox.TabIndex = 0;
            this.documentListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.documentListBox_KeyPress);
            this.documentListBox.Click += new System.EventHandler(this.documentListBox_Click);
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
            this.panel1.PerformLayout();
            this.documentPanel.ResumeLayout(false);
            this.documentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox documentListBox;
        private System.Windows.Forms.Panel documentPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label entityLabel;
        private System.Windows.Forms.Label label1;
    }
}