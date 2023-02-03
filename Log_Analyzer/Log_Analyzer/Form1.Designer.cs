namespace Log_Analyzer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Filter1B = new System.Windows.Forms.TextBox();
            this.Filter1C = new System.Windows.Forms.TextBox();
            this.Filter2A = new System.Windows.Forms.TextBox();
            this.Filter2B = new System.Windows.Forms.TextBox();
            this.Filter2C = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.FilteredLogs = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FilteredCountLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.ShowPartial = new System.Windows.Forms.Button();
            this.ControlsBackground = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MatchedNumText = new System.Windows.Forms.TextBox();
            this.EnterToFilterLabel = new System.Windows.Forms.Label();
            this.StatusBackground = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.Filter1APanel = new System.Windows.Forms.Panel();
            this.Filter1A = new System.Windows.Forms.TextBox();
            this.Filter1CPanel = new System.Windows.Forms.Panel();
            this.Filter1BPanel = new System.Windows.Forms.Panel();
            this.Filter2APanel = new System.Windows.Forms.Panel();
            this.Filter2BPanel = new System.Windows.Forms.Panel();
            this.Filter2CPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MatchedNumPanel = new System.Windows.Forms.Panel();
            this.DisplayLogsBackground = new System.Windows.Forms.Panel();
            this.ControlsBackground.SuspendLayout();
            this.StatusBackground.SuspendLayout();
            this.Filter1APanel.SuspendLayout();
            this.Filter1CPanel.SuspendLayout();
            this.Filter1BPanel.SuspendLayout();
            this.Filter2APanel.SuspendLayout();
            this.Filter2BPanel.SuspendLayout();
            this.Filter2CPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DisplayLogsBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filter1B
            // 
            this.Filter1B.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filter1B.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Filter1B.Location = new System.Drawing.Point(8, 3);
            this.Filter1B.Name = "Filter1B";
            this.Filter1B.PlaceholderText = "Second Filter";
            this.Filter1B.Size = new System.Drawing.Size(250, 16);
            this.Filter1B.TabIndex = 1;
            this.Filter1B.TextChanged += new System.EventHandler(this.Filter1B_TextChanged);
            // 
            // Filter1C
            // 
            this.Filter1C.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filter1C.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Filter1C.Location = new System.Drawing.Point(8, 3);
            this.Filter1C.Name = "Filter1C";
            this.Filter1C.PlaceholderText = "Third Filter";
            this.Filter1C.Size = new System.Drawing.Size(250, 16);
            this.Filter1C.TabIndex = 2;
            this.Filter1C.TextChanged += new System.EventHandler(this.Filter1C_TextChanged);
            // 
            // Filter2A
            // 
            this.Filter2A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filter2A.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Filter2A.Location = new System.Drawing.Point(8, 3);
            this.Filter2A.Name = "Filter2A";
            this.Filter2A.PlaceholderText = "First Filter";
            this.Filter2A.Size = new System.Drawing.Size(250, 16);
            this.Filter2A.TabIndex = 3;
            this.Filter2A.TextChanged += new System.EventHandler(this.Filter2A_TextChanged);
            // 
            // Filter2B
            // 
            this.Filter2B.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filter2B.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Filter2B.Location = new System.Drawing.Point(8, 3);
            this.Filter2B.Name = "Filter2B";
            this.Filter2B.PlaceholderText = "Second Filter";
            this.Filter2B.Size = new System.Drawing.Size(250, 16);
            this.Filter2B.TabIndex = 4;
            this.Filter2B.TextChanged += new System.EventHandler(this.Filter2B_TextChanged);
            // 
            // Filter2C
            // 
            this.Filter2C.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filter2C.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Filter2C.Location = new System.Drawing.Point(8, 3);
            this.Filter2C.Name = "Filter2C";
            this.Filter2C.PlaceholderText = "Third Filter";
            this.Filter2C.Size = new System.Drawing.Size(250, 16);
            this.Filter2C.TabIndex = 5;
            this.Filter2C.TextChanged += new System.EventHandler(this.Filter2C_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filter Set 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter Set 2";
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FilterButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.FilterButton.FlatAppearance.BorderSize = 2;
            this.FilterButton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FilterButton.Location = new System.Drawing.Point(207, 533);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(83, 28);
            this.FilterButton.TabIndex = 8;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // FilteredLogs
            // 
            this.FilteredLogs.BackColor = System.Drawing.Color.White;
            this.FilteredLogs.ForeColor = System.Drawing.Color.Black;
            this.FilteredLogs.Location = new System.Drawing.Point(14, 12);
            this.FilteredLogs.Multiline = true;
            this.FilteredLogs.Name = "FilteredLogs";
            this.FilteredLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FilteredLogs.Size = new System.Drawing.Size(1199, 787);
            this.FilteredLogs.TabIndex = 9;
            this.FilteredLogs.WordWrap = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 22);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Select a File";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // FilteredCountLabel
            // 
            this.FilteredCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FilteredCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.FilteredCountLabel.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilteredCountLabel.ForeColor = System.Drawing.Color.White;
            this.FilteredCountLabel.Location = new System.Drawing.Point(6, 25);
            this.FilteredCountLabel.Name = "FilteredCountLabel";
            this.FilteredCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FilteredCountLabel.Size = new System.Drawing.Size(259, 61);
            this.FilteredCountLabel.TabIndex = 11;
            this.FilteredCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.White;
            this.LoadingLabel.Location = new System.Drawing.Point(3, 102);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoadingLabel.Size = new System.Drawing.Size(262, 22);
            this.LoadingLabel.TabIndex = 12;
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadingLabel.Visible = false;
            // 
            // ShowPartial
            // 
            this.ShowPartial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ShowPartial.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowPartial.Location = new System.Drawing.Point(75, 533);
            this.ShowPartial.Name = "ShowPartial";
            this.ShowPartial.Size = new System.Drawing.Size(116, 28);
            this.ShowPartial.TabIndex = 13;
            this.ShowPartial.Text = "Show Partial Logs";
            this.ShowPartial.UseVisualStyleBackColor = false;
            this.ShowPartial.Visible = false;
            this.ShowPartial.Click += new System.EventHandler(this.ShowPartial_Click);
            // 
            // ControlsBackground
            // 
            this.ControlsBackground.BackColor = System.Drawing.Color.AliceBlue;
            this.ControlsBackground.Controls.Add(this.label4);
            this.ControlsBackground.Controls.Add(this.label3);
            this.ControlsBackground.Controls.Add(this.MatchedNumText);
            this.ControlsBackground.Controls.Add(this.EnterToFilterLabel);
            this.ControlsBackground.Controls.Add(this.ShowPartial);
            this.ControlsBackground.Controls.Add(this.FilterButton);
            this.ControlsBackground.Controls.Add(this.StatusBackground);
            this.ControlsBackground.Controls.Add(this.Filter1APanel);
            this.ControlsBackground.Controls.Add(this.Filter1CPanel);
            this.ControlsBackground.Controls.Add(this.Filter1BPanel);
            this.ControlsBackground.Controls.Add(this.Filter2APanel);
            this.ControlsBackground.Controls.Add(this.Filter2BPanel);
            this.ControlsBackground.Controls.Add(this.Filter2CPanel);
            this.ControlsBackground.Controls.Add(this.panel1);
            this.ControlsBackground.Controls.Add(this.panel2);
            this.ControlsBackground.Controls.Add(this.MatchedNumPanel);
            this.ControlsBackground.Location = new System.Drawing.Point(25, 12);
            this.ControlsBackground.Name = "ControlsBackground";
            this.ControlsBackground.Size = new System.Drawing.Size(325, 815);
            this.ControlsBackground.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "matched logs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "I want to see the first";
            // 
            // MatchedNumText
            // 
            this.MatchedNumText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatchedNumText.Location = new System.Drawing.Point(35, 96);
            this.MatchedNumText.Name = "MatchedNumText";
            this.MatchedNumText.PlaceholderText = "Enter a Number";
            this.MatchedNumText.Size = new System.Drawing.Size(94, 16);
            this.MatchedNumText.TabIndex = 22;
            // 
            // EnterToFilterLabel
            // 
            this.EnterToFilterLabel.AutoSize = true;
            this.EnterToFilterLabel.Font = new System.Drawing.Font("Bahnschrift", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterToFilterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EnterToFilterLabel.Location = new System.Drawing.Point(207, 564);
            this.EnterToFilterLabel.Name = "EnterToFilterLabel";
            this.EnterToFilterLabel.Size = new System.Drawing.Size(96, 12);
            this.EnterToFilterLabel.TabIndex = 16;
            this.EnterToFilterLabel.Text = "Press Enter To Filter";
            // 
            // StatusBackground
            // 
            this.StatusBackground.BackColor = System.Drawing.Color.LightSkyBlue;
            this.StatusBackground.Controls.Add(this.StatusLabel);
            this.StatusBackground.Controls.Add(this.FilteredCountLabel);
            this.StatusBackground.Controls.Add(this.LoadingLabel);
            this.StatusBackground.Location = new System.Drawing.Point(25, 590);
            this.StatusBackground.Name = "StatusBackground";
            this.StatusBackground.Size = new System.Drawing.Size(268, 197);
            this.StatusBackground.TabIndex = 13;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(6, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(3);
            this.StatusLabel.Size = new System.Drawing.Size(50, 22);
            this.StatusLabel.TabIndex = 13;
            this.StatusLabel.Text = "Status";
            // 
            // Filter1APanel
            // 
            this.Filter1APanel.BackColor = System.Drawing.Color.White;
            this.Filter1APanel.Controls.Add(this.Filter1A);
            this.Filter1APanel.Location = new System.Drawing.Point(25, 220);
            this.Filter1APanel.Name = "Filter1APanel";
            this.Filter1APanel.Size = new System.Drawing.Size(268, 22);
            this.Filter1APanel.TabIndex = 14;
            // 
            // Filter1A
            // 
            this.Filter1A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filter1A.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Filter1A.Location = new System.Drawing.Point(8, 3);
            this.Filter1A.Name = "Filter1A";
            this.Filter1A.PlaceholderText = "First Filter";
            this.Filter1A.Size = new System.Drawing.Size(250, 16);
            this.Filter1A.TabIndex = 0;
            this.Filter1A.Tag = "";
            this.Filter1A.TextChanged += new System.EventHandler(this.Filter1A_TextChanged);
            // 
            // Filter1CPanel
            // 
            this.Filter1CPanel.BackColor = System.Drawing.Color.White;
            this.Filter1CPanel.Controls.Add(this.Filter1C);
            this.Filter1CPanel.Location = new System.Drawing.Point(25, 308);
            this.Filter1CPanel.Name = "Filter1CPanel";
            this.Filter1CPanel.Size = new System.Drawing.Size(268, 22);
            this.Filter1CPanel.TabIndex = 16;
            // 
            // Filter1BPanel
            // 
            this.Filter1BPanel.BackColor = System.Drawing.Color.White;
            this.Filter1BPanel.Controls.Add(this.Filter1B);
            this.Filter1BPanel.Location = new System.Drawing.Point(25, 264);
            this.Filter1BPanel.Name = "Filter1BPanel";
            this.Filter1BPanel.Size = new System.Drawing.Size(268, 22);
            this.Filter1BPanel.TabIndex = 15;
            // 
            // Filter2APanel
            // 
            this.Filter2APanel.BackColor = System.Drawing.Color.White;
            this.Filter2APanel.Controls.Add(this.Filter2A);
            this.Filter2APanel.Location = new System.Drawing.Point(25, 400);
            this.Filter2APanel.Name = "Filter2APanel";
            this.Filter2APanel.Size = new System.Drawing.Size(268, 22);
            this.Filter2APanel.TabIndex = 17;
            // 
            // Filter2BPanel
            // 
            this.Filter2BPanel.BackColor = System.Drawing.Color.White;
            this.Filter2BPanel.Controls.Add(this.Filter2B);
            this.Filter2BPanel.Location = new System.Drawing.Point(25, 446);
            this.Filter2BPanel.Name = "Filter2BPanel";
            this.Filter2BPanel.Size = new System.Drawing.Size(268, 22);
            this.Filter2BPanel.TabIndex = 18;
            // 
            // Filter2CPanel
            // 
            this.Filter2CPanel.BackColor = System.Drawing.Color.White;
            this.Filter2CPanel.Controls.Add(this.Filter2C);
            this.Filter2CPanel.Location = new System.Drawing.Point(25, 491);
            this.Filter2CPanel.Name = "Filter2CPanel";
            this.Filter2CPanel.Size = new System.Drawing.Size(268, 22);
            this.Filter2CPanel.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 23);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 23);
            this.panel2.TabIndex = 21;
            // 
            // MatchedNumPanel
            // 
            this.MatchedNumPanel.BackColor = System.Drawing.Color.White;
            this.MatchedNumPanel.Location = new System.Drawing.Point(25, 93);
            this.MatchedNumPanel.Name = "MatchedNumPanel";
            this.MatchedNumPanel.Size = new System.Drawing.Size(115, 23);
            this.MatchedNumPanel.TabIndex = 25;
            // 
            // DisplayLogsBackground
            // 
            this.DisplayLogsBackground.BackColor = System.Drawing.Color.White;
            this.DisplayLogsBackground.Controls.Add(this.FilteredLogs);
            this.DisplayLogsBackground.Location = new System.Drawing.Point(396, 12);
            this.DisplayLogsBackground.Name = "DisplayLogsBackground";
            this.DisplayLogsBackground.Size = new System.Drawing.Size(1227, 815);
            this.DisplayLogsBackground.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1649, 854);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ControlsBackground);
            this.Controls.Add(this.DisplayLogsBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Log Analyzer";
            this.ControlsBackground.ResumeLayout(false);
            this.ControlsBackground.PerformLayout();
            this.StatusBackground.ResumeLayout(false);
            this.StatusBackground.PerformLayout();
            this.Filter1APanel.ResumeLayout(false);
            this.Filter1APanel.PerformLayout();
            this.Filter1CPanel.ResumeLayout(false);
            this.Filter1CPanel.PerformLayout();
            this.Filter1BPanel.ResumeLayout(false);
            this.Filter1BPanel.PerformLayout();
            this.Filter2APanel.ResumeLayout(false);
            this.Filter2APanel.PerformLayout();
            this.Filter2BPanel.ResumeLayout(false);
            this.Filter2BPanel.PerformLayout();
            this.Filter2CPanel.ResumeLayout(false);
            this.Filter2CPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.DisplayLogsBackground.ResumeLayout(false);
            this.DisplayLogsBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox Filter1B;
        private TextBox Filter1C;
        private TextBox Filter2A;
        private TextBox Filter2B;
        private TextBox Filter2C;
        private Label label1;
        private Label label2;
        private Button FilterButton;
        private TextBox FilteredLogs;
        private ComboBox comboBox1;
        private Label FilteredCountLabel;
        private Label LoadingLabel;
        private Button ShowPartial;
        private Panel ControlsBackground;
        private Panel DisplayLogsBackground;
        private Panel StatusBackground;
        private Label StatusLabel;
        private Panel Filter1APanel;
        private TextBox Filter1A;
        private Panel Filter1CPanel;
        private Panel Filter1BPanel;
        private Panel Filter2APanel;
        private Panel Filter2BPanel;
        private Panel Filter2CPanel;
        private Label EnterToFilterLabel;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private TextBox MatchedNumText;
        private Panel MatchedNumPanel;
    }
}