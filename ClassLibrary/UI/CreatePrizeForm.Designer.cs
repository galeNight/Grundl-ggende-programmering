namespace UI
{
    partial class CreatePrize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrize));
            this.Headerlable = new System.Windows.Forms.Label();
            this.PlaceNumberValue = new System.Windows.Forms.TextBox();
            this.PlaceNumberLable = new System.Windows.Forms.Label();
            this.PlaceNameValue = new System.Windows.Forms.TextBox();
            this.PricePercentageLable = new System.Windows.Forms.Label();
            this.PriceAmountValue = new System.Windows.Forms.TextBox();
            this.PlaceNameLable = new System.Windows.Forms.Label();
            this.PrizePercentageValue = new System.Windows.Forms.TextBox();
            this.PriceAmountLable = new System.Windows.Forms.Label();
            this.Orlable = new System.Windows.Forms.Label();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Headerlable
            // 
            this.Headerlable.AutoSize = true;
            this.Headerlable.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Headerlable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Headerlable.Location = new System.Drawing.Point(12, 9);
            this.Headerlable.Name = "Headerlable";
            this.Headerlable.Size = new System.Drawing.Size(209, 50);
            this.Headerlable.TabIndex = 12;
            this.Headerlable.Text = "Create Prize";
            // 
            // PlaceNumberValue
            // 
            this.PlaceNumberValue.Location = new System.Drawing.Point(196, 97);
            this.PlaceNumberValue.Name = "PlaceNumberValue";
            this.PlaceNumberValue.Size = new System.Drawing.Size(216, 35);
            this.PlaceNumberValue.TabIndex = 14;
            this.PlaceNumberValue.TextChanged += new System.EventHandler(this.PLaceNumberValue_TextChanged);
            // 
            // PlaceNumberLable
            // 
            this.PlaceNumberLable.AutoSize = true;
            this.PlaceNumberLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceNumberLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PlaceNumberLable.Location = new System.Drawing.Point(12, 95);
            this.PlaceNumberLable.Name = "PlaceNumberLable";
            this.PlaceNumberLable.Size = new System.Drawing.Size(178, 37);
            this.PlaceNumberLable.TabIndex = 13;
            this.PlaceNumberLable.Text = "Place number";
            // 
            // PlaceNameValue
            // 
            this.PlaceNameValue.Location = new System.Drawing.Point(196, 150);
            this.PlaceNameValue.Name = "PlaceNameValue";
            this.PlaceNameValue.Size = new System.Drawing.Size(216, 35);
            this.PlaceNameValue.TabIndex = 16;
            // 
            // PricePercentageLable
            // 
            this.PricePercentageLable.AutoSize = true;
            this.PricePercentageLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PricePercentageLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PricePercentageLable.Location = new System.Drawing.Point(9, 353);
            this.PricePercentageLable.Name = "PricePercentageLable";
            this.PricePercentageLable.Size = new System.Drawing.Size(212, 37);
            this.PricePercentageLable.TabIndex = 15;
            this.PricePercentageLable.Text = "Prize Percentage";
            this.PricePercentageLable.Click += new System.EventHandler(this.PricePercentageLable_Click);
            // 
            // PriceAmountValue
            // 
            this.PriceAmountValue.Location = new System.Drawing.Point(196, 203);
            this.PriceAmountValue.Name = "PriceAmountValue";
            this.PriceAmountValue.Size = new System.Drawing.Size(216, 35);
            this.PriceAmountValue.TabIndex = 18;
            // 
            // PlaceNameLable
            // 
            this.PlaceNameLable.AutoSize = true;
            this.PlaceNameLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceNameLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PlaceNameLable.Location = new System.Drawing.Point(12, 148);
            this.PlaceNameLable.Name = "PlaceNameLable";
            this.PlaceNameLable.Size = new System.Drawing.Size(157, 37);
            this.PlaceNameLable.TabIndex = 17;
            this.PlaceNameLable.Text = "Place Name";
            this.PlaceNameLable.Click += new System.EventHandler(this.label2_Click);
            // 
            // PrizePercentageValue
            // 
            this.PrizePercentageValue.Location = new System.Drawing.Point(230, 356);
            this.PrizePercentageValue.Name = "PrizePercentageValue";
            this.PrizePercentageValue.Size = new System.Drawing.Size(216, 35);
            this.PrizePercentageValue.TabIndex = 20;
            // 
            // PriceAmountLable
            // 
            this.PriceAmountLable.AutoSize = true;
            this.PriceAmountLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceAmountLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PriceAmountLable.Location = new System.Drawing.Point(12, 201);
            this.PriceAmountLable.Name = "PriceAmountLable";
            this.PriceAmountLable.Size = new System.Drawing.Size(176, 37);
            this.PriceAmountLable.TabIndex = 19;
            this.PriceAmountLable.Text = "Prize Amount";
            this.PriceAmountLable.Click += new System.EventHandler(this.label3_Click);
            // 
            // Orlable
            // 
            this.Orlable.AutoSize = true;
            this.Orlable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Orlable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Orlable.Location = new System.Drawing.Point(153, 287);
            this.Orlable.Name = "Orlable";
            this.Orlable.Size = new System.Drawing.Size(68, 37);
            this.Orlable.TabIndex = 21;
            this.Orlable.Text = "-Or-";
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreatePrizeButton.Location = new System.Drawing.Point(153, 480);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(203, 55);
            this.CreatePrizeButton.TabIndex = 26;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 583);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.Orlable);
            this.Controls.Add(this.PrizePercentageValue);
            this.Controls.Add(this.PriceAmountLable);
            this.Controls.Add(this.PriceAmountValue);
            this.Controls.Add(this.PlaceNameLable);
            this.Controls.Add(this.PlaceNameValue);
            this.Controls.Add(this.PricePercentageLable);
            this.Controls.Add(this.PlaceNumberValue);
            this.Controls.Add(this.PlaceNumberLable);
            this.Controls.Add(this.Headerlable);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreatePrize";
            this.Text = "CreatePrizeForm";
            this.Load += new System.EventHandler(this.CreatePrize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Headerlable;
        private TextBox PlaceNumberValue;
        private Label PlaceNumberLable;
        private TextBox PlaceNameValue;
        private Label PricePercentageLable;
        private TextBox PriceAmountValue;
        private Label PlaceNameLable;
        private TextBox PrizePercentageValue;
        private Label PriceAmountLable;
        private Label Orlable;
        private Button CreatePrizeButton;
    }
}