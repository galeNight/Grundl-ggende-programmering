namespace UI
{
    partial class CreateTeamsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamsForm));
            this.TeamNameValues = new System.Windows.Forms.TextBox();
            this.TeamNameLable = new System.Windows.Forms.Label();
            this.Headerlable = new System.Windows.Forms.Label();
            this.Addmemberbutton = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLable = new System.Windows.Forms.Label();
            this.AddNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLable = new System.Windows.Forms.Label();
            this.LastNameValues = new System.Windows.Forms.TextBox();
            this.LastNameLable = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailLable = new System.Windows.Forms.Label();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLable = new System.Windows.Forms.Label();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.teamMemberListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValues
            // 
            this.TeamNameValues.Location = new System.Drawing.Point(26, 124);
            this.TeamNameValues.Name = "TeamNameValues";
            this.TeamNameValues.Size = new System.Drawing.Size(250, 35);
            this.TeamNameValues.TabIndex = 13;
            // 
            // TeamNameLable
            // 
            this.TeamNameLable.AutoSize = true;
            this.TeamNameLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamNameLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TeamNameLable.Location = new System.Drawing.Point(26, 84);
            this.TeamNameLable.Name = "TeamNameLable";
            this.TeamNameLable.Size = new System.Drawing.Size(157, 37);
            this.TeamNameLable.TabIndex = 12;
            this.TeamNameLable.Text = "Team Name";
            // 
            // Headerlable
            // 
            this.Headerlable.AutoSize = true;
            this.Headerlable.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Headerlable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Headerlable.Location = new System.Drawing.Point(12, 9);
            this.Headerlable.Name = "Headerlable";
            this.Headerlable.Size = new System.Drawing.Size(213, 50);
            this.Headerlable.TabIndex = 11;
            this.Headerlable.Text = "Create Team";
            // 
            // Addmemberbutton
            // 
            this.Addmemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Addmemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Addmemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Addmemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addmemberbutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Addmemberbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Addmemberbutton.Location = new System.Drawing.Point(47, 306);
            this.Addmemberbutton.Name = "Addmemberbutton";
            this.Addmemberbutton.Size = new System.Drawing.Size(215, 54);
            this.Addmemberbutton.TabIndex = 19;
            this.Addmemberbutton.Text = "Add Member";
            this.Addmemberbutton.UseVisualStyleBackColor = true;
            this.Addmemberbutton.Click += new System.EventHandler(this.Addmemberbutton_Click);
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamMemberDropDown.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(26, 242);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(250, 45);
            this.SelectTeamMemberDropDown.TabIndex = 18;
            // 
            // SelectTeamMemberLable
            // 
            this.SelectTeamMemberLable.AutoSize = true;
            this.SelectTeamMemberLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamMemberLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SelectTeamMemberLable.Location = new System.Drawing.Point(28, 202);
            this.SelectTeamMemberLable.Name = "SelectTeamMemberLable";
            this.SelectTeamMemberLable.Size = new System.Drawing.Size(263, 37);
            this.SelectTeamMemberLable.TabIndex = 17;
            this.SelectTeamMemberLable.Text = "Select Team Member";
            // 
            // AddNewMemberGroupBox
            // 
            this.AddNewMemberGroupBox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberGroupBox.Controls.Add(this.cellphoneValue);
            this.AddNewMemberGroupBox.Controls.Add(this.cellphoneLable);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailValue);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailLable);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameValues);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameLable);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameLable);
            this.AddNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewMemberGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddNewMemberGroupBox.Location = new System.Drawing.Point(12, 382);
            this.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            this.AddNewMemberGroupBox.Size = new System.Drawing.Size(479, 291);
            this.AddNewMemberGroupBox.TabIndex = 20;
            this.AddNewMemberGroupBox.TabStop = false;
            this.AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(246, 37);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(216, 43);
            this.FirstNameValue.TabIndex = 10;
            this.FirstNameValue.TextChanged += new System.EventHandler(this.FirstNameValue_TextChanged);
            // 
            // FirstNameLable
            // 
            this.FirstNameLable.AutoSize = true;
            this.FirstNameLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FirstNameLable.Location = new System.Drawing.Point(13, 34);
            this.FirstNameLable.Name = "FirstNameLable";
            this.FirstNameLable.Size = new System.Drawing.Size(144, 37);
            this.FirstNameLable.TabIndex = 9;
            this.FirstNameLable.Text = "First Name";
            // 
            // LastNameValues
            // 
            this.LastNameValues.Location = new System.Drawing.Point(246, 77);
            this.LastNameValues.Name = "LastNameValues";
            this.LastNameValues.Size = new System.Drawing.Size(216, 43);
            this.LastNameValues.TabIndex = 12;
            this.LastNameValues.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastNameLable
            // 
            this.LastNameLable.AutoSize = true;
            this.LastNameLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LastNameLable.Location = new System.Drawing.Point(13, 75);
            this.LastNameLable.Name = "LastNameLable";
            this.LastNameLable.Size = new System.Drawing.Size(142, 37);
            this.LastNameLable.TabIndex = 11;
            this.LastNameLable.Text = "Last Name";
            // 
            // EmailValue
            // 
            this.EmailValue.Location = new System.Drawing.Point(246, 118);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(216, 43);
            this.EmailValue.TabIndex = 14;
            // 
            // EmailLable
            // 
            this.EmailLable.AutoSize = true;
            this.EmailLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EmailLable.Location = new System.Drawing.Point(13, 116);
            this.EmailLable.Name = "EmailLable";
            this.EmailLable.Size = new System.Drawing.Size(82, 37);
            this.EmailLable.TabIndex = 13;
            this.EmailLable.Text = "Email";
            this.EmailLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(246, 160);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(216, 43);
            this.cellphoneValue.TabIndex = 16;
            this.cellphoneValue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cellphoneLable
            // 
            this.cellphoneLable.AutoSize = true;
            this.cellphoneLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellphoneLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellphoneLable.Location = new System.Drawing.Point(13, 157);
            this.cellphoneLable.Name = "cellphoneLable";
            this.cellphoneLable.Size = new System.Drawing.Size(237, 37);
            this.cellphoneLable.TabIndex = 15;
            this.cellphoneLable.Text = "cellphone Number";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateMemberButton.Location = new System.Drawing.Point(162, 225);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(172, 54);
            this.CreateMemberButton.TabIndex = 20;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMemberListBox
            // 
            this.teamMemberListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMemberListBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamMemberListBox.FormattingEnabled = true;
            this.teamMemberListBox.ItemHeight = 30;
            this.teamMemberListBox.Location = new System.Drawing.Point(522, 119);
            this.teamMemberListBox.Name = "teamMemberListBox";
            this.teamMemberListBox.Size = new System.Drawing.Size(308, 542);
            this.teamMemberListBox.TabIndex = 21;
            // 
            // DeleteSelectedMemberButton
            // 
            this.DeleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DeleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectedMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteSelectedMemberButton.Location = new System.Drawing.Point(853, 306);
            this.DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            this.DeleteSelectedMemberButton.Size = new System.Drawing.Size(132, 82);
            this.DeleteSelectedMemberButton.TabIndex = 22;
            this.DeleteSelectedMemberButton.Text = " Delete Selected";
            this.DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateTeamButton.Location = new System.Drawing.Point(377, 687);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(249, 88);
            this.CreateTeamButton.TabIndex = 25;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 787);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedMemberButton);
            this.Controls.Add(this.teamMemberListBox);
            this.Controls.Add(this.AddNewMemberGroupBox);
            this.Controls.Add(this.Addmemberbutton);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.SelectTeamMemberLable);
            this.Controls.Add(this.TeamNameValues);
            this.Controls.Add(this.TeamNameLable);
            this.Controls.Add(this.Headerlable);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamsForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CreateTeamsForm_Load);
            this.AddNewMemberGroupBox.ResumeLayout(false);
            this.AddNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TeamNameValues;
        private Label TeamNameLable;
        private Label Headerlable;
        private Button Addmemberbutton;
        private ComboBox SelectTeamMemberDropDown;
        private Label SelectTeamMemberLable;
        private GroupBox AddNewMemberGroupBox;
        private TextBox FirstNameValue;
        private Label FirstNameLable;
        private TextBox LastNameValues;
        private Label LastNameLable;
        private TextBox EmailValue;
        private Label EmailLable;
        private TextBox cellphoneValue;
        private Label cellphoneLable;
        private Button CreateMemberButton;
        private ListBox teamMemberListBox;
        private Button DeleteSelectedMemberButton;
        private Button CreateTeamButton;
    }
}