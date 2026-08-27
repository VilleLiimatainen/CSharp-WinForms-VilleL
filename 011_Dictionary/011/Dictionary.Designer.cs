namespace _011
{
    partial class Dictionary
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
            gbLuodaanDictionary = new GroupBox();
            btnLuoDictionary = new Button();
            gbLisataanElementteja = new GroupBox();
            tbValue = new TextBox();
            tbKey = new TextBox();
            labelValue = new Label();
            labelKey = new Label();
            btnLisaa = new Button();
            gbHaetaanElementteja = new GroupBox();
            tbKeyHae = new TextBox();
            labelAuto = new Label();
            labelValueHae = new Label();
            labelKeyHae = new Label();
            btnHae = new Button();
            gbLuodaanDictionary.SuspendLayout();
            gbLisataanElementteja.SuspendLayout();
            gbHaetaanElementteja.SuspendLayout();
            SuspendLayout();
            // 
            // gbLuodaanDictionary
            // 
            gbLuodaanDictionary.BackColor = Color.Silver;
            gbLuodaanDictionary.Controls.Add(btnLuoDictionary);
            gbLuodaanDictionary.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            gbLuodaanDictionary.Location = new Point(183, 55);
            gbLuodaanDictionary.Name = "gbLuodaanDictionary";
            gbLuodaanDictionary.Size = new Size(379, 105);
            gbLuodaanDictionary.TabIndex = 0;
            gbLuodaanDictionary.TabStop = false;
            gbLuodaanDictionary.Text = "LUODAAN Dictionary";
            // 
            // btnLuoDictionary
            // 
            btnLuoDictionary.BackColor = SystemColors.ButtonShadow;
            btnLuoDictionary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuoDictionary.Location = new Point(72, 37);
            btnLuoDictionary.Name = "btnLuoDictionary";
            btnLuoDictionary.Size = new Size(229, 37);
            btnLuoDictionary.TabIndex = 0;
            btnLuoDictionary.Text = "Luo Dictionary";
            btnLuoDictionary.UseVisualStyleBackColor = false;
            btnLuoDictionary.Click += btnLuoDictionary_Click;
            // 
            // gbLisataanElementteja
            // 
            gbLisataanElementteja.BackColor = Color.Silver;
            gbLisataanElementteja.Controls.Add(tbValue);
            gbLisataanElementteja.Controls.Add(tbKey);
            gbLisataanElementteja.Controls.Add(labelValue);
            gbLisataanElementteja.Controls.Add(labelKey);
            gbLisataanElementteja.Controls.Add(btnLisaa);
            gbLisataanElementteja.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            gbLisataanElementteja.Location = new Point(183, 166);
            gbLisataanElementteja.Name = "gbLisataanElementteja";
            gbLisataanElementteja.Size = new Size(379, 105);
            gbLisataanElementteja.TabIndex = 1;
            gbLisataanElementteja.TabStop = false;
            gbLisataanElementteja.Text = "LISÄTÄÄN ELEMENTTEJÄ";
            // 
            // tbValue
            // 
            tbValue.Location = new Point(71, 59);
            tbValue.Name = "tbValue";
            tbValue.Size = new Size(211, 23);
            tbValue.TabIndex = 4;
            // 
            // tbKey
            // 
            tbKey.Location = new Point(71, 29);
            tbKey.Name = "tbKey";
            tbKey.Size = new Size(211, 23);
            tbKey.TabIndex = 3;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Font = new Font("Segoe UI", 9F);
            labelValue.Location = new Point(27, 62);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(38, 15);
            labelValue.TabIndex = 2;
            labelValue.Text = "Value:";
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Font = new Font("Segoe UI", 9F);
            labelKey.Location = new Point(27, 32);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(29, 15);
            labelKey.TabIndex = 1;
            labelKey.Text = "Key:";
            // 
            // btnLisaa
            // 
            btnLisaa.BackColor = SystemColors.ButtonShadow;
            btnLisaa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLisaa.Location = new Point(288, 51);
            btnLisaa.Name = "btnLisaa";
            btnLisaa.Size = new Size(73, 37);
            btnLisaa.TabIndex = 0;
            btnLisaa.Text = "Lisää";
            btnLisaa.UseVisualStyleBackColor = false;
            btnLisaa.Click += btnLisaa_Click;
            // 
            // gbHaetaanElementteja
            // 
            gbHaetaanElementteja.BackColor = Color.Silver;
            gbHaetaanElementteja.Controls.Add(tbKeyHae);
            gbHaetaanElementteja.Controls.Add(labelAuto);
            gbHaetaanElementteja.Controls.Add(labelValueHae);
            gbHaetaanElementteja.Controls.Add(labelKeyHae);
            gbHaetaanElementteja.Controls.Add(btnHae);
            gbHaetaanElementteja.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            gbHaetaanElementteja.Location = new Point(183, 277);
            gbHaetaanElementteja.Name = "gbHaetaanElementteja";
            gbHaetaanElementteja.Size = new Size(379, 105);
            gbHaetaanElementteja.TabIndex = 2;
            gbHaetaanElementteja.TabStop = false;
            gbHaetaanElementteja.Text = "HAETAAN ELEMENTTEJÄ";
            // 
            // tbKeyHae
            // 
            tbKeyHae.Location = new Point(71, 30);
            tbKeyHae.Name = "tbKeyHae";
            tbKeyHae.Size = new Size(211, 23);
            tbKeyHae.TabIndex = 5;
            // 
            // labelAuto
            // 
            labelAuto.AutoSize = true;
            labelAuto.BackColor = Color.Salmon;
            labelAuto.BorderStyle = BorderStyle.FixedSingle;
            labelAuto.Font = new Font("Segoe UI", 10F);
            labelAuto.Location = new Point(71, 60);
            labelAuto.MinimumSize = new Size(41, 21);
            labelAuto.Name = "labelAuto";
            labelAuto.Size = new Size(41, 21);
            labelAuto.TabIndex = 4;
            labelAuto.Text = "Auto";
            // 
            // labelValueHae
            // 
            labelValueHae.AutoSize = true;
            labelValueHae.Font = new Font("Segoe UI", 9F);
            labelValueHae.Location = new Point(27, 62);
            labelValueHae.Name = "labelValueHae";
            labelValueHae.Size = new Size(38, 15);
            labelValueHae.TabIndex = 3;
            labelValueHae.Text = "Value:";
            // 
            // labelKeyHae
            // 
            labelKeyHae.AutoSize = true;
            labelKeyHae.Font = new Font("Segoe UI", 9F);
            labelKeyHae.Location = new Point(27, 33);
            labelKeyHae.Name = "labelKeyHae";
            labelKeyHae.Size = new Size(29, 15);
            labelKeyHae.TabIndex = 2;
            labelKeyHae.Text = "Key:";
            // 
            // btnHae
            // 
            btnHae.BackColor = SystemColors.ButtonShadow;
            btnHae.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHae.Location = new Point(288, 22);
            btnHae.Name = "btnHae";
            btnHae.Size = new Size(73, 37);
            btnHae.TabIndex = 0;
            btnHae.Text = "Hae";
            btnHae.UseVisualStyleBackColor = false;
            btnHae.Click += btnHae_Click;
            // 
            // Dictionary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(779, 468);
            Controls.Add(gbHaetaanElementteja);
            Controls.Add(gbLisataanElementteja);
            Controls.Add(gbLuodaanDictionary);
            Name = "Dictionary";
            Text = "Dictionary";
            gbLuodaanDictionary.ResumeLayout(false);
            gbLisataanElementteja.ResumeLayout(false);
            gbLisataanElementteja.PerformLayout();
            gbHaetaanElementteja.ResumeLayout(false);
            gbHaetaanElementteja.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbLuodaanDictionary;
        private Button btnLuoDictionary;
        private GroupBox gbLisataanElementteja;
        private Button btnLisaa;
        private GroupBox gbHaetaanElementteja;
        private Button btnHae;
        private TextBox tbValue;
        private TextBox tbKey;
        private Label labelValue;
        private Label labelKey;
        private Label labelAuto;
        private Label labelValueHae;
        private Label labelKeyHae;
        private TextBox tbKeyHae;
    }
}
