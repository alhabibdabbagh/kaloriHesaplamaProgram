namespace ornek1
{
    partial class fbesinlistesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbesin = new System.Windows.Forms.ListBox();
            this.lpormik = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lkalori = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bekle = new System.Windows.Forms.Button();
            this.tbesin = new System.Windows.Forms.TextBox();
            this.tpormik = new System.Windows.Forms.TextBox();
            this.tkalori = new System.Windows.Forms.TextBox();
            this.bduzenle = new System.Windows.Forms.Button();
            this.bdyaz = new System.Windows.Forms.Button();
            this.bdoku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Besin";
            // 
            // lbesin
            // 
            this.lbesin.FormattingEnabled = true;
            this.lbesin.Location = new System.Drawing.Point(16, 29);
            this.lbesin.Name = "lbesin";
            this.lbesin.Size = new System.Drawing.Size(105, 199);
            this.lbesin.TabIndex = 10;
            // 
            // lpormik
            // 
            this.lpormik.FormattingEnabled = true;
            this.lpormik.Location = new System.Drawing.Point(127, 29);
            this.lpormik.Name = "lpormik";
            this.lpormik.Size = new System.Drawing.Size(58, 199);
            this.lpormik.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pors. Mik.";
            // 
            // lkalori
            // 
            this.lkalori.FormattingEnabled = true;
            this.lkalori.Location = new System.Drawing.Point(191, 29);
            this.lkalori.Name = "lkalori";
            this.lkalori.Size = new System.Drawing.Size(58, 199);
            this.lkalori.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kalori";
            // 
            // bekle
            // 
            this.bekle.Location = new System.Drawing.Point(16, 264);
            this.bekle.Name = "bekle";
            this.bekle.Size = new System.Drawing.Size(105, 40);
            this.bekle.TabIndex = 25;
            this.bekle.Text = "Ekle";
            this.bekle.UseVisualStyleBackColor = true;
            this.bekle.Click += new System.EventHandler(this.bekle_Click);
            // 
            // tbesin
            // 
            this.tbesin.Location = new System.Drawing.Point(16, 235);
            this.tbesin.Name = "tbesin";
            this.tbesin.Size = new System.Drawing.Size(105, 20);
            this.tbesin.TabIndex = 26;
            // 
            // tpormik
            // 
            this.tpormik.Location = new System.Drawing.Point(127, 234);
            this.tpormik.Name = "tpormik";
            this.tpormik.Size = new System.Drawing.Size(58, 20);
            this.tpormik.TabIndex = 27;
            // 
            // tkalori
            // 
            this.tkalori.Location = new System.Drawing.Point(191, 234);
            this.tkalori.Name = "tkalori";
            this.tkalori.Size = new System.Drawing.Size(58, 20);
            this.tkalori.TabIndex = 28;
            // 
            // bduzenle
            // 
            this.bduzenle.Location = new System.Drawing.Point(144, 264);
            this.bduzenle.Name = "bduzenle";
            this.bduzenle.Size = new System.Drawing.Size(105, 40);
            this.bduzenle.TabIndex = 29;
            this.bduzenle.Text = "Düzenle";
            this.bduzenle.UseVisualStyleBackColor = true;
            this.bduzenle.Click += new System.EventHandler(this.bduzenle_Click);
            // 
            // bdyaz
            // 
            this.bdyaz.Location = new System.Drawing.Point(16, 310);
            this.bdyaz.Name = "bdyaz";
            this.bdyaz.Size = new System.Drawing.Size(105, 40);
            this.bdyaz.TabIndex = 30;
            this.bdyaz.Text = "Dosyaya Yaz";
            this.bdyaz.UseVisualStyleBackColor = true;
            this.bdyaz.Click += new System.EventHandler(this.bdyaz_Click);
            // 
            // bdoku
            // 
            this.bdoku.Location = new System.Drawing.Point(144, 310);
            this.bdoku.Name = "bdoku";
            this.bdoku.Size = new System.Drawing.Size(105, 40);
            this.bdoku.TabIndex = 31;
            this.bdoku.Text = "Dosyadan Oku";
            this.bdoku.UseVisualStyleBackColor = true;
            this.bdoku.Click += new System.EventHandler(this.bdoku_Click);
            // 
            // fbesinlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 361);
            this.Controls.Add(this.bdoku);
            this.Controls.Add(this.bdyaz);
            this.Controls.Add(this.bduzenle);
            this.Controls.Add(this.tkalori);
            this.Controls.Add(this.tpormik);
            this.Controls.Add(this.tbesin);
            this.Controls.Add(this.bekle);
            this.Controls.Add(this.lkalori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lpormik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbesin);
            this.Controls.Add(this.label1);
            this.Name = "fbesinlistesi";
            this.Text = "fbesinlistesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbesin;
        private System.Windows.Forms.ListBox lpormik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lkalori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bekle;
        private System.Windows.Forms.TextBox tbesin;
        private System.Windows.Forms.TextBox tpormik;
        private System.Windows.Forms.TextBox tkalori;
        private System.Windows.Forms.Button bduzenle;
        private System.Windows.Forms.Button bdyaz;
        private System.Windows.Forms.Button bdoku;
    }
}