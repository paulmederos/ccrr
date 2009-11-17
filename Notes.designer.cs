namespace WordCloud
{
    partial class Notes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.noteBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.documentList = new System.Windows.Forms.ListBox();
            this.documentButton = new System.Windows.Forms.Button();
            this.documentBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.perpList = new System.Windows.Forms.ListBox();
            this.perpButton = new System.Windows.Forms.Button();
            this.perpBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hideButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(3, 37);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(502, 445);
            this.noteBox.TabIndex = 5;
            this.noteBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.documentList);
            this.panel2.Controls.Add(this.documentButton);
            this.panel2.Controls.Add(this.documentBox);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 486);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Notable Documents";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // documentList
            // 
            this.documentList.FormattingEnabled = true;
            this.documentList.Location = new System.Drawing.Point(3, 61);
            this.documentList.Name = "documentList";
            this.documentList.Size = new System.Drawing.Size(171, 420);
            this.documentList.TabIndex = 2;
            // 
            // documentButton
            // 
            this.documentButton.Location = new System.Drawing.Point(141, 37);
            this.documentButton.Name = "documentButton";
            this.documentButton.Size = new System.Drawing.Size(34, 23);
            this.documentButton.TabIndex = 1;
            this.documentButton.Text = "Add";
            this.documentButton.UseVisualStyleBackColor = true;
            this.documentButton.Click += new System.EventHandler(this.documentButton_Click);
            // 
            // documentBox
            // 
            this.documentBox.Location = new System.Drawing.Point(4, 38);
            this.documentBox.Name = "documentBox";
            this.documentBox.Size = new System.Drawing.Size(131, 20);
            this.documentBox.TabIndex = 0;
            this.documentBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.hideButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.noteBox);
            this.panel3.Location = new System.Drawing.Point(382, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 487);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Summary of Findings";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.perpList);
            this.panel1.Controls.Add(this.perpButton);
            this.panel1.Controls.Add(this.perpBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(197, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 486);
            this.panel1.TabIndex = 8;
            // 
            // perpList
            // 
            this.perpList.FormattingEnabled = true;
            this.perpList.Location = new System.Drawing.Point(3, 61);
            this.perpList.Name = "perpList";
            this.perpList.Size = new System.Drawing.Size(171, 420);
            this.perpList.TabIndex = 10;
            // 
            // perpButton
            // 
            this.perpButton.Location = new System.Drawing.Point(142, 37);
            this.perpButton.Name = "perpButton";
            this.perpButton.Size = new System.Drawing.Size(34, 23);
            this.perpButton.TabIndex = 9;
            this.perpButton.Text = "Add";
            this.perpButton.UseVisualStyleBackColor = true;
            this.perpButton.Click += new System.EventHandler(this.perpButton_Click);
            // 
            // perpBox
            // 
            this.perpBox.Location = new System.Drawing.Point(3, 38);
            this.perpBox.Name = "perpBox";
            this.perpBox.Size = new System.Drawing.Size(133, 20);
            this.perpBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Perpetrators";
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(415, 3);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(90, 28);
            this.hideButton.TabIndex = 7;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 510);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Notes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button documentButton;
        private System.Windows.Forms.TextBox documentBox;
        private System.Windows.Forms.ListBox documentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox perpList;
        private System.Windows.Forms.Button perpButton;
        private System.Windows.Forms.TextBox perpBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button hideButton;
    }
}

