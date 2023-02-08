namespace UI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.Headerlable = new System.Windows.Forms.Label();
            this.TrunamentNameValues = new System.Windows.Forms.TextBox();
            this.TurnamentNameLable = new System.Windows.Forms.Label();
            this.EntryFeeValues = new System.Windows.Forms.TextBox();
            this.EntryFeeLable = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLable = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.ddteambutton = new System.Windows.Forms.Button();
            this.CreatePrizebutton = new System.Windows.Forms.Button();
            this.TurnamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.TurnementPLayersLable = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.DeleteSelectPrizeButton = new System.Windows.Forms.Button();
            this.PrizeLable = new System.Windows.Forms.Label();
            this.PrizeListbox = new System.Windows.Forms.ListBox();
            this.CreateTurnamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Headerlable
            // 
            this.Headerlable.AutoSize = true;
            this.Headerlable.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Headerlable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Headerlable.Location = new System.Drawing.Point(12, 21);
            this.Headerlable.Name = "Headerlable";
            this.Headerlable.Size = new System.Drawing.Size(297, 50);
            this.Headerlable.TabIndex = 1;
            this.Headerlable.Text = "Create Turnament";
            // 
            // TrunamentNameValues
            // 
            this.TrunamentNameValues.Location = new System.Drawing.Point(27, 134);
            this.TrunamentNameValues.Name = "TrunamentNameValues";
            this.TrunamentNameValues.Size = new System.Drawing.Size(290, 35);
            this.TrunamentNameValues.TabIndex = 10;
            // 
            // TurnamentNameLable
            // 
            this.TurnamentNameLable.AutoSize = true;
            this.TurnamentNameLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TurnamentNameLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TurnamentNameLable.Location = new System.Drawing.Point(27, 94);
            this.TurnamentNameLable.Name = "TurnamentNameLable";
            this.TurnamentNameLable.Size = new System.Drawing.Size(223, 37);
            this.TurnamentNameLable.TabIndex = 9;
            this.TurnamentNameLable.Text = "Turnament Name";
            // 
            // EntryFeeValues
            // 
            this.EntryFeeValues.Location = new System.Drawing.Point(151, 196);
            this.EntryFeeValues.Name = "EntryFeeValues";
            this.EntryFeeValues.Size = new System.Drawing.Size(100, 35);
            this.EntryFeeValues.TabIndex = 12;
            this.EntryFeeValues.Text = "0";
            this.EntryFeeValues.TextChanged += new System.EventHandler(this.TeamOneScoreValue_TextChanged);
            // 
            // EntryFeeLable
            // 
            this.EntryFeeLable.AutoSize = true;
            this.EntryFeeLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntryFeeLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EntryFeeLable.Location = new System.Drawing.Point(27, 196);
            this.EntryFeeLable.Name = "EntryFeeLable";
            this.EntryFeeLable.Size = new System.Drawing.Size(118, 37);
            this.EntryFeeLable.TabIndex = 11;
            this.EntryFeeLable.Text = "EntryFee";
            this.EntryFeeLable.Click += new System.EventHandler(this.TeamOneScoreLable_Click);
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamDropDown.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(27, 299);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(290, 45);
            this.SelectTeamDropDown.TabIndex = 14;
            // 
            // SelectTeamLable
            // 
            this.SelectTeamLable.AutoSize = true;
            this.SelectTeamLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SelectTeamLable.Location = new System.Drawing.Point(27, 259);
            this.SelectTeamLable.Name = "SelectTeamLable";
            this.SelectTeamLable.Size = new System.Drawing.Size(156, 37);
            this.SelectTeamLable.TabIndex = 13;
            this.SelectTeamLable.Text = "Select Team";
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Location = new System.Drawing.Point(196, 266);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(121, 30);
            this.CreateNewTeamLink.TabIndex = 15;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create New";
            // 
            // ddteambutton
            // 
            this.ddteambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ddteambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ddteambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ddteambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddteambutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ddteambutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ddteambutton.Location = new System.Drawing.Point(102, 350);
            this.ddteambutton.Name = "ddteambutton";
            this.ddteambutton.Size = new System.Drawing.Size(132, 54);
            this.ddteambutton.TabIndex = 16;
            this.ddteambutton.Text = "Add team";
            this.ddteambutton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizebutton
            // 
            this.CreatePrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreatePrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizebutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizebutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreatePrizebutton.Location = new System.Drawing.Point(102, 422);
            this.CreatePrizebutton.Name = "CreatePrizebutton";
            this.CreatePrizebutton.Size = new System.Drawing.Size(149, 54);
            this.CreatePrizebutton.TabIndex = 17;
            this.CreatePrizebutton.Text = "Create Prize";
            this.CreatePrizebutton.UseVisualStyleBackColor = true;
            // 
            // TurnamentPlayerListBox
            // 
            this.TurnamentPlayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TurnamentPlayerListBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TurnamentPlayerListBox.FormattingEnabled = true;
            this.TurnamentPlayerListBox.ItemHeight = 30;
            this.TurnamentPlayerListBox.Location = new System.Drawing.Point(444, 134);
            this.TurnamentPlayerListBox.Name = "TurnamentPlayerListBox";
            this.TurnamentPlayerListBox.Size = new System.Drawing.Size(328, 182);
            this.TurnamentPlayerListBox.TabIndex = 18;
            this.TurnamentPlayerListBox.SelectedIndexChanged += new System.EventHandler(this.TurnamentPlayerListBox_SelectedIndexChanged);
            // 
            // TurnementPLayersLable
            // 
            this.TurnementPLayersLable.AutoSize = true;
            this.TurnementPLayersLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TurnementPLayersLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TurnementPLayersLable.Location = new System.Drawing.Point(524, 94);
            this.TurnementPLayersLable.Name = "TurnementPLayersLable";
            this.TurnementPLayersLable.Size = new System.Drawing.Size(185, 37);
            this.TurnementPLayersLable.TabIndex = 19;
            this.TurnementPLayersLable.Text = "Teams/players";
            // 
            // DeleteSelectedPlayerButton
            // 
            this.DeleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DeleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectedPlayerButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteSelectedPlayerButton.Location = new System.Drawing.Point(791, 149);
            this.DeleteSelectedPlayerButton.Name = "DeleteSelectedPlayerButton";
            this.DeleteSelectedPlayerButton.Size = new System.Drawing.Size(132, 82);
            this.DeleteSelectedPlayerButton.TabIndex = 20;
            this.DeleteSelectedPlayerButton.Text = " Delete Selected";
            this.DeleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedPlayerButton.Click += new System.EventHandler(this.Scorebutton_Click);
            // 
            // DeleteSelectPrizeButton
            // 
            this.DeleteSelectPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DeleteSelectPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectPrizeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectPrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteSelectPrizeButton.Location = new System.Drawing.Point(791, 390);
            this.DeleteSelectPrizeButton.Name = "DeleteSelectPrizeButton";
            this.DeleteSelectPrizeButton.Size = new System.Drawing.Size(163, 86);
            this.DeleteSelectPrizeButton.TabIndex = 23;
            this.DeleteSelectPrizeButton.Text = " Delete Selected";
            this.DeleteSelectPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizeLable
            // 
            this.PrizeLable.AutoSize = true;
            this.PrizeLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizeLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PrizeLable.Location = new System.Drawing.Point(524, 335);
            this.PrizeLable.Name = "PrizeLable";
            this.PrizeLable.Size = new System.Drawing.Size(185, 37);
            this.PrizeLable.TabIndex = 22;
            this.PrizeLable.Text = "Teams/players";
            // 
            // PrizeListbox
            // 
            this.PrizeListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizeListbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PrizeListbox.FormattingEnabled = true;
            this.PrizeListbox.ItemHeight = 30;
            this.PrizeListbox.Location = new System.Drawing.Point(444, 375);
            this.PrizeListbox.Name = "PrizeListbox";
            this.PrizeListbox.Size = new System.Drawing.Size(328, 182);
            this.PrizeListbox.TabIndex = 21;
            // 
            // CreateTurnamentButton
            // 
            this.CreateTurnamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTurnamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTurnamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTurnamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTurnamentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTurnamentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateTurnamentButton.Location = new System.Drawing.Point(291, 581);
            this.CreateTurnamentButton.Name = "CreateTurnamentButton";
            this.CreateTurnamentButton.Size = new System.Drawing.Size(249, 88);
            this.CreateTurnamentButton.TabIndex = 24;
            this.CreateTurnamentButton.Text = "Create Turnament";
            this.CreateTurnamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 681);
            this.Controls.Add(this.CreateTurnamentButton);
            this.Controls.Add(this.DeleteSelectPrizeButton);
            this.Controls.Add(this.PrizeLable);
            this.Controls.Add(this.PrizeListbox);
            this.Controls.Add(this.DeleteSelectedPlayerButton);
            this.Controls.Add(this.TurnementPLayersLable);
            this.Controls.Add(this.TurnamentPlayerListBox);
            this.Controls.Add(this.CreatePrizebutton);
            this.Controls.Add(this.ddteambutton);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLable);
            this.Controls.Add(this.EntryFeeValues);
            this.Controls.Add(this.EntryFeeLable);
            this.Controls.Add(this.TrunamentNameValues);
            this.Controls.Add(this.TurnamentNameLable);
            this.Controls.Add(this.Headerlable);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Headerlable;
        private TextBox TrunamentNameValues;
        private Label TurnamentNameLable;
        private TextBox EntryFeeValues;
        private Label EntryFeeLable;
        private ComboBox SelectTeamDropDown;
        private Label SelectTeamLable;
        private LinkLabel CreateNewTeamLink;
        private Button ddteambutton;
        private Button CreatePrizebutton;
        private ListBox TurnamentPlayerListBox;
        private Label TurnementPLayersLable;
        private Button DeleteSelectedPlayerButton;
        private Button DeleteSelectPrizeButton;
        private Label PrizeLable;
        private ListBox PrizeListbox;
        private Button CreateTurnamentButton;
    }
}