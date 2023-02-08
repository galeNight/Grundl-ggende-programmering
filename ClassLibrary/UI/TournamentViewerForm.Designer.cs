namespace UI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.Headerlable = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLable = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyChecbox = new System.Windows.Forms.CheckBox();
            this.MatchupListBox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScoreLable = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLable = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.Versuslable = new System.Windows.Forms.Label();
            this.Scorebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Headerlable
            // 
            this.Headerlable.AutoSize = true;
            this.Headerlable.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Headerlable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Headerlable.Location = new System.Drawing.Point(12, 18);
            this.Headerlable.Name = "Headerlable";
            this.Headerlable.Size = new System.Drawing.Size(194, 50);
            this.Headerlable.TabIndex = 0;
            this.Headerlable.Text = "Turnament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TournamentName.Location = new System.Drawing.Point(198, 18);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(150, 50);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // RoundLable
            // 
            this.RoundLable.AutoSize = true;
            this.RoundLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RoundLable.Location = new System.Drawing.Point(21, 78);
            this.RoundLable.Name = "RoundLable";
            this.RoundLable.Size = new System.Drawing.Size(94, 37);
            this.RoundLable.TabIndex = 2;
            this.RoundLable.Text = "Round";
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundDropDown.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(121, 77);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(209, 45);
            this.RoundDropDown.TabIndex = 3;
            // 
            // UnplayedOnlyChecbox
            // 
            this.UnplayedOnlyChecbox.AutoSize = true;
            this.UnplayedOnlyChecbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyChecbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnplayedOnlyChecbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UnplayedOnlyChecbox.Location = new System.Drawing.Point(121, 128);
            this.UnplayedOnlyChecbox.Name = "UnplayedOnlyChecbox";
            this.UnplayedOnlyChecbox.Size = new System.Drawing.Size(209, 41);
            this.UnplayedOnlyChecbox.TabIndex = 4;
            this.UnplayedOnlyChecbox.Text = "Unplayed Only";
            this.UnplayedOnlyChecbox.UseVisualStyleBackColor = true;
            // 
            // MatchupListBox
            // 
            this.MatchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MatchupListBox.FormattingEnabled = true;
            this.MatchupListBox.ItemHeight = 30;
            this.MatchupListBox.Location = new System.Drawing.Point(12, 175);
            this.MatchupListBox.Name = "MatchupListBox";
            this.MatchupListBox.Size = new System.Drawing.Size(318, 272);
            this.MatchupListBox.TabIndex = 5;
            this.MatchupListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TeamOneName.Location = new System.Drawing.Point(429, 186);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(171, 37);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "<Team One>";
            // 
            // TeamOneScoreLable
            // 
            this.TeamOneScoreLable.AutoSize = true;
            this.TeamOneScoreLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TeamOneScoreLable.Location = new System.Drawing.Point(429, 237);
            this.TeamOneScoreLable.Name = "TeamOneScoreLable";
            this.TeamOneScoreLable.Size = new System.Drawing.Size(82, 37);
            this.TeamOneScoreLable.TabIndex = 7;
            this.TeamOneScoreLable.Text = "Score";
            this.TeamOneScoreLable.Click += new System.EventHandler(this.TeamOneScoreLable_Click);
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Location = new System.Drawing.Point(531, 237);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.TeamOneScoreValue.TabIndex = 8;
            this.TeamOneScoreValue.TextChanged += new System.EventHandler(this.TeamOneScoreValue_TextChanged);
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(531, 410);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(100, 35);
            this.TeamTwoScoreValue.TabIndex = 11;
            this.TeamTwoScoreValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TeamTwoScoreLable
            // 
            this.TeamTwoScoreLable.AutoSize = true;
            this.TeamTwoScoreLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoScoreLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TeamTwoScoreLable.Location = new System.Drawing.Point(429, 410);
            this.TeamTwoScoreLable.Name = "TeamTwoScoreLable";
            this.TeamTwoScoreLable.Size = new System.Drawing.Size(82, 37);
            this.TeamTwoScoreLable.TabIndex = 10;
            this.TeamTwoScoreLable.Text = "Score";
            this.TeamTwoScoreLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TeamTwoName.Location = new System.Drawing.Point(429, 357);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(164, 37);
            this.TeamTwoName.TabIndex = 9;
            this.TeamTwoName.Text = "<TeamTwo>";
            this.TeamTwoName.Click += new System.EventHandler(this.label2_Click);
            // 
            // Versuslable
            // 
            this.Versuslable.AutoSize = true;
            this.Versuslable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Versuslable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Versuslable.Location = new System.Drawing.Point(502, 308);
            this.Versuslable.Name = "Versuslable";
            this.Versuslable.Size = new System.Drawing.Size(70, 37);
            this.Versuslable.TabIndex = 12;
            this.Versuslable.Text = "-VS-";
            // 
            // Scorebutton
            // 
            this.Scorebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Scorebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Scorebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Scorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scorebutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Scorebutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Scorebutton.Location = new System.Drawing.Point(654, 302);
            this.Scorebutton.Name = "Scorebutton";
            this.Scorebutton.Size = new System.Drawing.Size(132, 54);
            this.Scorebutton.TabIndex = 13;
            this.Scorebutton.Text = "Score";
            this.Scorebutton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 554);
            this.Controls.Add(this.Scorebutton);
            this.Controls.Add(this.Versuslable);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.TeamTwoScoreLable);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScoreLable);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.MatchupListBox);
            this.Controls.Add(this.UnplayedOnlyChecbox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.RoundLable);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.Headerlable);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Headerlable;
        private Label TournamentName;
        private Label RoundLable;
        private ComboBox RoundDropDown;
        private CheckBox UnplayedOnlyChecbox;
        private ListBox MatchupListBox;
        private Label TeamOneName;
        private Label TeamOneScoreLable;
        private TextBox TeamOneScoreValue;
        private TextBox TeamTwoScoreValue;
        private Label TeamTwoScoreLable;
        private Label TeamTwoName;
        private Label Versuslable;
        private Button Scorebutton;
    }
}