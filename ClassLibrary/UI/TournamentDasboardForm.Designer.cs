namespace UI
{
    partial class TournamentDasboardForm
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
            this.Headerlable = new System.Windows.Forms.Label();
            this.LoadExistingTurnamentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLable = new System.Windows.Forms.Label();
            this.CreateTournamentbutton = new System.Windows.Forms.Button();
            this.LoadTournamentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Headerlable
            // 
            this.Headerlable.AutoSize = true;
            this.Headerlable.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Headerlable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Headerlable.Location = new System.Drawing.Point(161, 42);
            this.Headerlable.Name = "Headerlable";
            this.Headerlable.Size = new System.Drawing.Size(355, 50);
            this.Headerlable.TabIndex = 13;
            this.Headerlable.Text = "TournamentDasboard";
            this.Headerlable.Click += new System.EventHandler(this.Headerlable_Click);
            // 
            // LoadExistingTurnamentDropDown
            // 
            this.LoadExistingTurnamentDropDown.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadExistingTurnamentDropDown.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoadExistingTurnamentDropDown.FormattingEnabled = true;
            this.LoadExistingTurnamentDropDown.Location = new System.Drawing.Point(213, 191);
            this.LoadExistingTurnamentDropDown.Name = "LoadExistingTurnamentDropDown";
            this.LoadExistingTurnamentDropDown.Size = new System.Drawing.Size(250, 45);
            this.LoadExistingTurnamentDropDown.TabIndex = 20;
            this.LoadExistingTurnamentDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectTeamMemberDropDown_SelectedIndexChanged);
            // 
            // LoadExistingTournamentLable
            // 
            this.LoadExistingTournamentLable.AutoSize = true;
            this.LoadExistingTournamentLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadExistingTournamentLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoadExistingTournamentLable.Location = new System.Drawing.Point(177, 126);
            this.LoadExistingTournamentLable.Name = "LoadExistingTournamentLable";
            this.LoadExistingTournamentLable.Size = new System.Drawing.Size(322, 37);
            this.LoadExistingTournamentLable.TabIndex = 19;
            this.LoadExistingTournamentLable.Text = "Load Existing Tournament";
            // 
            // CreateTournamentbutton
            // 
            this.CreateTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentbutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateTournamentbutton.Location = new System.Drawing.Point(237, 365);
            this.CreateTournamentbutton.Name = "CreateTournamentbutton";
            this.CreateTournamentbutton.Size = new System.Drawing.Size(203, 55);
            this.CreateTournamentbutton.TabIndex = 27;
            this.CreateTournamentbutton.Text = "Create Tournament";
            this.CreateTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // LoadTournamentbutton
            // 
            this.LoadTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LoadTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.LoadTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentbutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadTournamentbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoadTournamentbutton.Location = new System.Drawing.Point(231, 271);
            this.LoadTournamentbutton.Name = "LoadTournamentbutton";
            this.LoadTournamentbutton.Size = new System.Drawing.Size(215, 54);
            this.LoadTournamentbutton.TabIndex = 28;
            this.LoadTournamentbutton.Text = "Load Tournament";
            this.LoadTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // TournamentDasboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 481);
            this.Controls.Add(this.LoadTournamentbutton);
            this.Controls.Add(this.CreateTournamentbutton);
            this.Controls.Add(this.LoadExistingTurnamentDropDown);
            this.Controls.Add(this.LoadExistingTournamentLable);
            this.Controls.Add(this.Headerlable);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentDasboardForm";
            this.Text = "TournamentDasboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Headerlable;
        private ComboBox LoadExistingTurnamentDropDown;
        private Label LoadExistingTournamentLable;
        private Button CreateTournamentbutton;
        private Button LoadTournamentbutton;
    }
}