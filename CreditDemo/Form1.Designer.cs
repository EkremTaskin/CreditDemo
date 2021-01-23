namespace CreditDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbxKonut = new System.Windows.Forms.CheckBox();
            this.cbxTasit = new System.Windows.Forms.CheckBox();
            this.cbxihtiyac = new System.Windows.Forms.CheckBox();
            this.tbxKredi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lbxKrediler = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxKonut
            // 
            this.cbxKonut.AutoSize = true;
            this.cbxKonut.Location = new System.Drawing.Point(70, 83);
            this.cbxKonut.Name = "cbxKonut";
            this.cbxKonut.Size = new System.Drawing.Size(88, 17);
            this.cbxKonut.TabIndex = 0;
            this.cbxKonut.Text = "Konut Kredisi";
            this.cbxKonut.UseVisualStyleBackColor = true;
            // 
            // cbxTasit
            // 
            this.cbxTasit.AutoSize = true;
            this.cbxTasit.Location = new System.Drawing.Point(70, 123);
            this.cbxTasit.Name = "cbxTasit";
            this.cbxTasit.Size = new System.Drawing.Size(83, 17);
            this.cbxTasit.TabIndex = 1;
            this.cbxTasit.Text = "Taşıt Kredisi";
            this.cbxTasit.UseVisualStyleBackColor = true;
            // 
            // cbxihtiyac
            // 
            this.cbxihtiyac.AutoSize = true;
            this.cbxihtiyac.Location = new System.Drawing.Point(70, 166);
            this.cbxihtiyac.Name = "cbxihtiyac";
            this.cbxihtiyac.Size = new System.Drawing.Size(91, 17);
            this.cbxihtiyac.TabIndex = 2;
            this.cbxihtiyac.Text = "İhtiyaç Kredisi";
            this.cbxihtiyac.UseVisualStyleBackColor = true;
            // 
            // tbxKredi
            // 
            this.tbxKredi.Location = new System.Drawing.Point(157, 247);
            this.tbxKredi.Name = "tbxKredi";
            this.tbxKredi.Size = new System.Drawing.Size(225, 20);
            this.tbxKredi.TabIndex = 3;
            this.tbxKredi.TextChanged += new System.EventHandler(this.tbxKredi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kredi Yaz :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.FlatAppearance.BorderSize = 0;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(70, 290);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(312, 44);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lbxKrediler
            // 
            this.lbxKrediler.FormattingEnabled = true;
            this.lbxKrediler.Location = new System.Drawing.Point(450, 81);
            this.lbxKrediler.Name = "lbxKrediler";
            this.lbxKrediler.Size = new System.Drawing.Size(299, 251);
            this.lbxKrediler.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(709, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(767, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbxKrediler);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxKredi);
            this.Controls.Add(this.cbxihtiyac);
            this.Controls.Add(this.cbxTasit);
            this.Controls.Add(this.cbxKonut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxKonut;
        private System.Windows.Forms.CheckBox cbxTasit;
        private System.Windows.Forms.CheckBox cbxihtiyac;
        private System.Windows.Forms.TextBox tbxKredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox lbxKrediler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

