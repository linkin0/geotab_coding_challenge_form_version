namespace JokeGenerator {
    partial class FormChuckNorris {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonGetJokes = new System.Windows.Forms.Button();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.comboBoxNumberOfJokes = new System.Windows.Forms.ComboBox();
            this.richTextBoxJokeDisplay = new System.Windows.Forms.RichTextBox();
            this.lableCategories = new System.Windows.Forms.Label();
            this.labelNumberOfJokes = new System.Windows.Forms.Label();
            this.lblJokes = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonGenerateRandomName = new System.Windows.Forms.Button();
            this.pictureBoxChuckNorris = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLightMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDarkMode = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuckNorris)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetJokes
            // 
            this.buttonGetJokes.Location = new System.Drawing.Point(467, 359);
            this.buttonGetJokes.Name = "buttonGetJokes";
            this.buttonGetJokes.Size = new System.Drawing.Size(75, 23);
            this.buttonGetJokes.TabIndex = 0;
            this.buttonGetJokes.Text = "Get Jokes";
            this.buttonGetJokes.UseVisualStyleBackColor = true;
            this.buttonGetJokes.Click += new System.EventHandler(this.buttonGetJokes_Click);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(96, 49);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategories.TabIndex = 1;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // comboBoxNumberOfJokes
            // 
            this.comboBoxNumberOfJokes.FormattingEnabled = true;
            this.comboBoxNumberOfJokes.Location = new System.Drawing.Point(223, 49);
            this.comboBoxNumberOfJokes.Name = "comboBoxNumberOfJokes";
            this.comboBoxNumberOfJokes.Size = new System.Drawing.Size(44, 21);
            this.comboBoxNumberOfJokes.TabIndex = 2;
            this.comboBoxNumberOfJokes.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumberOfJokes_SelectedIndexChanged);
            // 
            // richTextBoxJokeDisplay
            // 
            this.richTextBoxJokeDisplay.Location = new System.Drawing.Point(15, 145);
            this.richTextBoxJokeDisplay.Name = "richTextBoxJokeDisplay";
            this.richTextBoxJokeDisplay.ReadOnly = true;
            this.richTextBoxJokeDisplay.Size = new System.Drawing.Size(527, 208);
            this.richTextBoxJokeDisplay.TabIndex = 3;
            this.richTextBoxJokeDisplay.Text = "";
            // 
            // lableCategories
            // 
            this.lableCategories.AutoSize = true;
            this.lableCategories.Location = new System.Drawing.Point(93, 34);
            this.lableCategories.Name = "lableCategories";
            this.lableCategories.Size = new System.Drawing.Size(57, 13);
            this.lableCategories.TabIndex = 4;
            this.lableCategories.Text = "Categories";
            // 
            // labelNumberOfJokes
            // 
            this.labelNumberOfJokes.AutoSize = true;
            this.labelNumberOfJokes.Location = new System.Drawing.Point(220, 34);
            this.labelNumberOfJokes.Name = "labelNumberOfJokes";
            this.labelNumberOfJokes.Size = new System.Drawing.Size(87, 13);
            this.labelNumberOfJokes.TabIndex = 5;
            this.labelNumberOfJokes.Text = "Number of Jokes";
            // 
            // lblJokes
            // 
            this.lblJokes.AutoSize = true;
            this.lblJokes.Location = new System.Drawing.Point(12, 129);
            this.lblJokes.Name = "lblJokes";
            this.lblJokes.Size = new System.Drawing.Size(35, 13);
            this.lblJokes.TabIndex = 6;
            this.lblJokes.Text = "Jokes";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(93, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(134, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.Text = "Chuck Norris";
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // buttonGenerateRandomName
            // 
            this.buttonGenerateRandomName.Location = new System.Drawing.Point(240, 76);
            this.buttonGenerateRandomName.Name = "buttonGenerateRandomName";
            this.buttonGenerateRandomName.Size = new System.Drawing.Size(148, 23);
            this.buttonGenerateRandomName.TabIndex = 9;
            this.buttonGenerateRandomName.Text = "Generate Random Name";
            this.buttonGenerateRandomName.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomName.Click += new System.EventHandler(this.buttonGenerateRandomName_Click);
            // 
            // pictureBoxChuckNorris
            // 
            this.pictureBoxChuckNorris.Location = new System.Drawing.Point(16, 35);
            this.pictureBoxChuckNorris.Name = "pictureBoxChuckNorris";
            this.pictureBoxChuckNorris.Size = new System.Drawing.Size(74, 75);
            this.pictureBoxChuckNorris.TabIndex = 10;
            this.pictureBoxChuckNorris.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemView
            // 
            this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLightMode,
            this.ToolStripMenuItemDarkMode});
            this.toolStripMenuItemView.Name = "toolStripMenuItemView";
            this.toolStripMenuItemView.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemView.Text = "View";
            // 
            // toolStripMenuItemLightMode
            // 
            this.toolStripMenuItemLightMode.Name = "toolStripMenuItemLightMode";
            this.toolStripMenuItemLightMode.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemLightMode.Text = "Light mode";
            this.toolStripMenuItemLightMode.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemDarkMode
            // 
            this.ToolStripMenuItemDarkMode.Name = "ToolStripMenuItemDarkMode";
            this.ToolStripMenuItemDarkMode.Size = new System.Drawing.Size(135, 22);
            this.ToolStripMenuItemDarkMode.Text = "Dark mode";
            this.ToolStripMenuItemDarkMode.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // FormChuckNorris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 391);
            this.Controls.Add(this.pictureBoxChuckNorris);
            this.Controls.Add(this.buttonGenerateRandomName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.lblJokes);
            this.Controls.Add(this.labelNumberOfJokes);
            this.Controls.Add(this.lableCategories);
            this.Controls.Add(this.richTextBoxJokeDisplay);
            this.Controls.Add(this.comboBoxNumberOfJokes);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.buttonGetJokes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChuckNorris";
            this.Text = "Chuck Norris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuckNorris)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetJokes;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.ComboBox comboBoxNumberOfJokes;
        private System.Windows.Forms.RichTextBox richTextBoxJokeDisplay;
        private System.Windows.Forms.Label lableCategories;
        private System.Windows.Forms.Label labelNumberOfJokes;
        private System.Windows.Forms.Label lblJokes;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonGenerateRandomName;
        private System.Windows.Forms.PictureBox pictureBoxChuckNorris;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLightMode;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDarkMode;
    }
}

