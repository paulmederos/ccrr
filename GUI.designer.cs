namespace WordCloud
{
    partial class GUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.previousSearchBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savedPanel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordCloudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodLuckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BurstPanel = new WordCloud.GUI.MyPanel();
            this.homeButton = new System.Windows.Forms.Button();
            this.NumEntitiesLabel = new System.Windows.Forms.Label();
            this.sliderLabel = new System.Windows.Forms.Label();
            this.wedgesSlider = new System.Windows.Forms.TrackBar();
            this.entityTypes = new System.Windows.Forms.GroupBox();
            this.showDate = new System.Windows.Forms.CheckBox();
            this.showMoney = new System.Windows.Forms.CheckBox();
            this.showOrganization = new System.Windows.Forms.CheckBox();
            this.showLocation = new System.Windows.Forms.CheckBox();
            this.showPerson = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.searchPanel.SuspendLayout();
            this.savedPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.BurstPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wedgesSlider)).BeginInit();
            this.entityTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "DocuBurst";
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.AutoScroll = true;
            this.searchPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.previousSearchBox);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Location = new System.Drawing.Point(3, 24);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(227, 158);
            this.searchPanel.TabIndex = 1;
            // 
            // previousSearchBox
            // 
            this.previousSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.previousSearchBox.FormattingEnabled = true;
            this.previousSearchBox.Location = new System.Drawing.Point(41, 69);
            this.previousSearchBox.Name = "previousSearchBox";
            this.previousSearchBox.Size = new System.Drawing.Size(142, 69);
            this.previousSearchBox.TabIndex = 4;
            this.previousSearchBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.previousSearchBox_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Previous Searches";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(187, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(36, 24);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Go";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(3, 23);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(179, 20);
            this.searchBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // savedPanel
            // 
            this.savedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savedPanel.Controls.Add(this.treeView1);
            this.savedPanel.Controls.Add(this.label3);
            this.savedPanel.Location = new System.Drawing.Point(0, 172);
            this.savedPanel.Name = "savedPanel";
            this.savedPanel.Size = new System.Drawing.Size(227, 299);
            this.savedPanel.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.treeView1.Location = new System.Drawing.Point(-1, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(227, 311);
            this.treeView1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Saved";
            // 
            // sidePanel
            // 
            this.sidePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidePanel.Controls.Add(this.savedPanel);
            this.sidePanel.Controls.Add(this.searchPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel.Location = new System.Drawing.Point(665, 24);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(227, 471);
            this.sidePanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentsToolStripMenuItem,
            this.entitiesToolStripMenuItem,
            this.wordCloudToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.documentsToolStripMenuItem.Text = "Documents";
            this.documentsToolStripMenuItem.Click += new System.EventHandler(this.documentsToolStripMenuItem_Click);
            // 
            // entitiesToolStripMenuItem
            // 
            this.entitiesToolStripMenuItem.Name = "entitiesToolStripMenuItem";
            this.entitiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entitiesToolStripMenuItem.Text = "Entities";
            // 
            // wordCloudToolStripMenuItem
            // 
            this.wordCloudToolStripMenuItem.Name = "wordCloudToolStripMenuItem";
            this.wordCloudToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wordCloudToolStripMenuItem.Text = "Word Cloud";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodLuckToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // goodLuckToolStripMenuItem
            // 
            this.goodLuckToolStripMenuItem.Name = "goodLuckToolStripMenuItem";
            this.goodLuckToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.goodLuckToolStripMenuItem.Text = "Good Luck";
            // 
            // BurstPanel
            // 
            this.BurstPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BurstPanel.Controls.Add(this.homeButton);
            this.BurstPanel.Controls.Add(this.NumEntitiesLabel);
            this.BurstPanel.Controls.Add(this.sliderLabel);
            this.BurstPanel.Controls.Add(this.wedgesSlider);
            this.BurstPanel.Controls.Add(this.entityTypes);
            this.BurstPanel.Controls.Add(this.label4);
            this.BurstPanel.Location = new System.Drawing.Point(0, 24);
            this.BurstPanel.Name = "BurstPanel";
            this.BurstPanel.Size = new System.Drawing.Size(659, 471);
            this.BurstPanel.TabIndex = 4;
            this.BurstPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BurstPanel_Paint);
            this.BurstPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BurstPanel_MouseMove);
            this.BurstPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BurstPanel_MouseDown);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.homeButton.Location = new System.Drawing.Point(566, 292);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(85, 23);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // NumEntitiesLabel
            // 
            this.NumEntitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumEntitiesLabel.AutoSize = true;
            this.NumEntitiesLabel.Location = new System.Drawing.Point(12, 423);
            this.NumEntitiesLabel.Name = "NumEntitiesLabel";
            this.NumEntitiesLabel.Size = new System.Drawing.Size(108, 13);
            this.NumEntitiesLabel.TabIndex = 4;
            this.NumEntitiesLabel.Text = "Entities shown: 0 of 0";
            this.NumEntitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sliderLabel
            // 
            this.sliderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderLabel.Location = new System.Drawing.Point(252, 412);
            this.sliderLabel.Name = "sliderLabel";
            this.sliderLabel.Size = new System.Drawing.Size(99, 34);
            this.sliderLabel.TabIndex = 3;
            this.sliderLabel.Text = "Number of wedges:";
            this.sliderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wedgesSlider
            // 
            this.wedgesSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wedgesSlider.Location = new System.Drawing.Point(357, 418);
            this.wedgesSlider.Maximum = 40;
            this.wedgesSlider.Minimum = 11;
            this.wedgesSlider.Name = "wedgesSlider";
            this.wedgesSlider.Size = new System.Drawing.Size(197, 45);
            this.wedgesSlider.TabIndex = 2;
            this.wedgesSlider.Value = 20;
            this.wedgesSlider.Scroll += new System.EventHandler(this.wedgesSlider_Scroll);
            // 
            // entityTypes
            // 
            this.entityTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.entityTypes.Controls.Add(this.showDate);
            this.entityTypes.Controls.Add(this.showMoney);
            this.entityTypes.Controls.Add(this.showOrganization);
            this.entityTypes.Controls.Add(this.showLocation);
            this.entityTypes.Controls.Add(this.showPerson);
            this.entityTypes.Location = new System.Drawing.Point(560, 321);
            this.entityTypes.Name = "entityTypes";
            this.entityTypes.Size = new System.Drawing.Size(96, 138);
            this.entityTypes.TabIndex = 1;
            this.entityTypes.TabStop = false;
            this.entityTypes.Text = "Entity Types";
            // 
            // showDate
            // 
            this.showDate.AutoSize = true;
            this.showDate.Checked = true;
            this.showDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showDate.Location = new System.Drawing.Point(6, 114);
            this.showDate.Name = "showDate";
            this.showDate.Size = new System.Drawing.Size(49, 17);
            this.showDate.TabIndex = 4;
            this.showDate.Text = "Date";
            this.showDate.UseVisualStyleBackColor = true;
            this.showDate.CheckedChanged += new System.EventHandler(this.showDate_CheckedChanged);
            // 
            // showMoney
            // 
            this.showMoney.AutoSize = true;
            this.showMoney.Checked = true;
            this.showMoney.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMoney.ForeColor = System.Drawing.Color.Green;
            this.showMoney.Location = new System.Drawing.Point(6, 91);
            this.showMoney.Name = "showMoney";
            this.showMoney.Size = new System.Drawing.Size(58, 17);
            this.showMoney.TabIndex = 3;
            this.showMoney.Text = "Money";
            this.showMoney.UseVisualStyleBackColor = true;
            this.showMoney.CheckedChanged += new System.EventHandler(this.showMoney_CheckedChanged);
            // 
            // showOrganization
            // 
            this.showOrganization.AutoSize = true;
            this.showOrganization.Checked = true;
            this.showOrganization.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOrganization.ForeColor = System.Drawing.Color.Navy;
            this.showOrganization.Location = new System.Drawing.Point(6, 68);
            this.showOrganization.Name = "showOrganization";
            this.showOrganization.Size = new System.Drawing.Size(85, 17);
            this.showOrganization.TabIndex = 2;
            this.showOrganization.Text = "Organization";
            this.showOrganization.UseVisualStyleBackColor = true;
            this.showOrganization.CheckedChanged += new System.EventHandler(this.showOrganization_CheckedChanged);
            // 
            // showLocation
            // 
            this.showLocation.AutoSize = true;
            this.showLocation.Checked = true;
            this.showLocation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLocation.ForeColor = System.Drawing.Color.Olive;
            this.showLocation.Location = new System.Drawing.Point(6, 44);
            this.showLocation.Name = "showLocation";
            this.showLocation.Size = new System.Drawing.Size(67, 17);
            this.showLocation.TabIndex = 1;
            this.showLocation.Text = "Location";
            this.showLocation.UseVisualStyleBackColor = true;
            this.showLocation.CheckedChanged += new System.EventHandler(this.showLocation_CheckedChanged);
            // 
            // showPerson
            // 
            this.showPerson.AutoSize = true;
            this.showPerson.Checked = true;
            this.showPerson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.showPerson.Location = new System.Drawing.Point(6, 21);
            this.showPerson.Name = "showPerson";
            this.showPerson.Size = new System.Drawing.Size(59, 17);
            this.showPerson.TabIndex = 0;
            this.showPerson.Text = "Person";
            this.showPerson.UseVisualStyleBackColor = true;
            this.showPerson.CheckedChanged += new System.EventHandler(this.showPerson_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML files|*.xml";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(892, 495);
            this.Controls.Add(this.BurstPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.GUI_Resize);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.savedPanel.ResumeLayout(false);
            this.savedPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BurstPanel.ResumeLayout(false);
            this.BurstPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wedgesSlider)).EndInit();
            this.entityTypes.ResumeLayout(false);
            this.entityTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel savedPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListBox previousSearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private GUI.MyPanel BurstPanel;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem entitiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wordCloudToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem goodLuckToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox entityTypes;
		private System.Windows.Forms.CheckBox showOrganization;
		private System.Windows.Forms.CheckBox showLocation;
		private System.Windows.Forms.CheckBox showPerson;
		private System.Windows.Forms.CheckBox showDate;
		private System.Windows.Forms.CheckBox showMoney;
		private System.Windows.Forms.TrackBar wedgesSlider;
		private System.Windows.Forms.Label sliderLabel;
		private System.Windows.Forms.Label NumEntitiesLabel;
		private System.Windows.Forms.Button homeButton;
    }
}

