namespace _008
{
    partial class ArrayLotto
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
            btnArpaNappula = new Button();
            labelNumeroLabel = new Label();
            labelNumerot = new Label();
            labelLisaNumerot = new Label();
            textBoxNumero1 = new TextBox();
            textBoxNumero2 = new TextBox();
            textBoxNumero3 = new TextBox();
            textBoxNumero4 = new TextBox();
            textBoxNumero5 = new TextBox();
            textBoxNumero6 = new TextBox();
            textBoxNumero7 = new TextBox();
            labelArvaaNumerot = new Label();
            groupBox1 = new GroupBox();
            groupBoxOmatNumerot = new GroupBox();
            groupBoxTulokset = new GroupBox();
            label1 = new Label();
            labelTulokset = new Label();
            groupBox1.SuspendLayout();
            groupBoxOmatNumerot.SuspendLayout();
            groupBoxTulokset.SuspendLayout();
            SuspendLayout();
            // 
            // btnArpaNappula
            // 
            btnArpaNappula.BackColor = Color.Red;
            btnArpaNappula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnArpaNappula.Location = new Point(128, 53);
            btnArpaNappula.Name = "btnArpaNappula";
            btnArpaNappula.Size = new Size(174, 62);
            btnArpaNappula.TabIndex = 0;
            btnArpaNappula.Text = "Arvo lottonumerot";
            btnArpaNappula.UseVisualStyleBackColor = false;
            btnArpaNappula.Click += btnArpaNappula_Click;
            // 
            // labelNumeroLabel
            // 
            labelNumeroLabel.AutoSize = true;
            labelNumeroLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNumeroLabel.Location = new Point(45, 118);
            labelNumeroLabel.MinimumSize = new Size(50, 20);
            labelNumeroLabel.Name = "labelNumeroLabel";
            labelNumeroLabel.Size = new Size(77, 20);
            labelNumeroLabel.TabIndex = 1;
            labelNumeroLabel.Text = "Numerot:";
            // 
            // labelNumerot
            // 
            labelNumerot.AutoSize = true;
            labelNumerot.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNumerot.Location = new Point(128, 118);
            labelNumerot.MinimumSize = new Size(128, 20);
            labelNumerot.Name = "labelNumerot";
            labelNumerot.Size = new Size(134, 20);
            labelNumerot.TabIndex = 2;
            labelNumerot.Text = "Ei vielä numeroita";
            labelNumerot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLisaNumerot
            // 
            labelLisaNumerot.AutoSize = true;
            labelLisaNumerot.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelLisaNumerot.Location = new Point(45, 138);
            labelLisaNumerot.Name = "labelLisaNumerot";
            labelLisaNumerot.Size = new Size(101, 20);
            labelLisaNumerot.TabIndex = 3;
            labelLisaNumerot.Text = "Lisänumerot:";
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(148, 26);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.PlaceholderText = "0";
            textBoxNumero1.Size = new Size(24, 27);
            textBoxNumero1.TabIndex = 4;
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(178, 26);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.PlaceholderText = "0";
            textBoxNumero2.Size = new Size(24, 27);
            textBoxNumero2.TabIndex = 5;
            // 
            // textBoxNumero3
            // 
            textBoxNumero3.Location = new Point(208, 26);
            textBoxNumero3.Name = "textBoxNumero3";
            textBoxNumero3.PlaceholderText = "0";
            textBoxNumero3.Size = new Size(24, 27);
            textBoxNumero3.TabIndex = 6;
            // 
            // textBoxNumero4
            // 
            textBoxNumero4.Location = new Point(238, 26);
            textBoxNumero4.Name = "textBoxNumero4";
            textBoxNumero4.PlaceholderText = "0";
            textBoxNumero4.Size = new Size(24, 27);
            textBoxNumero4.TabIndex = 7;
            // 
            // textBoxNumero5
            // 
            textBoxNumero5.Location = new Point(268, 26);
            textBoxNumero5.Name = "textBoxNumero5";
            textBoxNumero5.PlaceholderText = "0";
            textBoxNumero5.Size = new Size(24, 27);
            textBoxNumero5.TabIndex = 8;
            // 
            // textBoxNumero6
            // 
            textBoxNumero6.Location = new Point(298, 26);
            textBoxNumero6.Name = "textBoxNumero6";
            textBoxNumero6.PlaceholderText = "0";
            textBoxNumero6.Size = new Size(24, 27);
            textBoxNumero6.TabIndex = 9;
            // 
            // textBoxNumero7
            // 
            textBoxNumero7.Location = new Point(328, 26);
            textBoxNumero7.Name = "textBoxNumero7";
            textBoxNumero7.PlaceholderText = "0";
            textBoxNumero7.Size = new Size(24, 27);
            textBoxNumero7.TabIndex = 10;
            // 
            // labelArvaaNumerot
            // 
            labelArvaaNumerot.AutoSize = true;
            labelArvaaNumerot.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelArvaaNumerot.Location = new Point(22, 29);
            labelArvaaNumerot.Name = "labelArvaaNumerot";
            labelArvaaNumerot.Size = new Size(120, 20);
            labelArvaaNumerot.TabIndex = 11;
            labelArvaaNumerot.Text = "Arvaa numerot:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelLisaNumerot);
            groupBox1.Controls.Add(labelNumerot);
            groupBox1.Controls.Add(labelNumeroLabel);
            groupBox1.Controls.Add(btnArpaNappula);
            groupBox1.Location = new Point(70, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 191);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lottorivin arpominen";
            // 
            // groupBoxOmatNumerot
            // 
            groupBoxOmatNumerot.Controls.Add(labelArvaaNumerot);
            groupBoxOmatNumerot.Controls.Add(textBoxNumero7);
            groupBoxOmatNumerot.Controls.Add(textBoxNumero6);
            groupBoxOmatNumerot.Controls.Add(textBoxNumero5);
            groupBoxOmatNumerot.Controls.Add(textBoxNumero3);
            groupBoxOmatNumerot.Controls.Add(textBoxNumero4);
            groupBoxOmatNumerot.Controls.Add(textBoxNumero2);
            groupBoxOmatNumerot.Controls.Add(textBoxNumero1);
            groupBoxOmatNumerot.Location = new Point(70, 5);
            groupBoxOmatNumerot.Name = "groupBoxOmatNumerot";
            groupBoxOmatNumerot.Size = new Size(440, 62);
            groupBoxOmatNumerot.TabIndex = 13;
            groupBoxOmatNumerot.TabStop = false;
            groupBoxOmatNumerot.Text = "Omat numerot";
            // 
            // groupBoxTulokset
            // 
            groupBoxTulokset.Controls.Add(label1);
            groupBoxTulokset.Controls.Add(labelTulokset);
            groupBoxTulokset.Location = new Point(70, 270);
            groupBoxTulokset.Name = "groupBoxTulokset";
            groupBoxTulokset.Size = new Size(440, 116);
            groupBoxTulokset.TabIndex = 14;
            groupBoxTulokset.TabStop = false;
            groupBoxTulokset.Text = "Tulokset";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(45, 52);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Tulokset:";
            // 
            // labelTulokset
            // 
            labelTulokset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelTulokset.AutoSize = true;
            labelTulokset.BackColor = SystemColors.Control;
            labelTulokset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTulokset.Location = new Point(128, 52);
            labelTulokset.Name = "labelTulokset";
            labelTulokset.Size = new Size(116, 20);
            labelTulokset.TabIndex = 0;
            labelTulokset.Text = "Ei vielä tuloksia";
            labelTulokset.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ArrayLotto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 412);
            Controls.Add(groupBoxTulokset);
            Controls.Add(groupBoxOmatNumerot);
            Controls.Add(groupBox1);
            Name = "ArrayLotto";
            Text = "ArrayLotto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxOmatNumerot.ResumeLayout(false);
            groupBoxOmatNumerot.PerformLayout();
            groupBoxTulokset.ResumeLayout(false);
            groupBoxTulokset.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnArpaNappula;
        private Label labelNumeroLabel;
        private Label labelNumerot;
        private Label labelLisaNumerot;
        private TextBox textBoxNumero1;
        private TextBox textBoxNumero2;
        private TextBox textBoxNumero3;
        private TextBox textBoxNumero4;
        private TextBox textBoxNumero5;
        private TextBox textBoxNumero6;
        private TextBox textBoxNumero7;
        private Label labelArvaaNumerot;
        private GroupBox groupBox1;
        private GroupBox groupBoxOmatNumerot;
        private GroupBox groupBoxTulokset;
        private Label labelTulokset;
        private Label label1;
    }
}
