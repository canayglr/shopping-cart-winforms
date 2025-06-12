namespace Proje
{
    partial class AdminPanel
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
            this.FormClosing += AdminPanel_FormClosing;
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            stok = new MaskedTextBox();
            label3 = new Label();
            ad = new TextBox();
            button1 = new Button();
            fiyat = new MaskedTextBox();
            silurun = new Button();
            duzenle = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(302, 77);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(245, 324);
            listBox1.TabIndex = 0;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 77);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 260);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Ürün Fiyatı";
            // 
            // stok
            // 
            stok.Location = new Point(56, 196);
            stok.Mask = "00000";
            stok.Name = "stok";
            stok.Size = new Size(125, 27);
            stok.TabIndex = 6;
            stok.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 173);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Ürün Stoğu";
            // 
            // ad
            // 
            ad.Location = new Point(56, 100);
            ad.Name = "ad";
            ad.Size = new Size(125, 27);
            ad.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(56, 360);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Ürün Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fiyat
            // 
            fiyat.Location = new Point(56, 303);
            fiyat.Mask = "00000";
            fiyat.Name = "fiyat";
            fiyat.Size = new Size(125, 27);
            fiyat.TabIndex = 9;
            fiyat.ValidatingType = typeof(int);
            // 
            // silurun
            // 
            silurun.Location = new Point(608, 150);
            silurun.Name = "silurun";
            silurun.Size = new Size(157, 29);
            silurun.TabIndex = 10;
            silurun.Text = "Seçilen Ürünü Sil";
            silurun.UseVisualStyleBackColor = true;
            silurun.Click += silurun_Click;
            // 
            // duzenle
            // 
            duzenle.Location = new Point(599, 251);
            duzenle.Name = "duzenle";
            duzenle.Size = new Size(175, 29);
            duzenle.TabIndex = 11;
            duzenle.Text = "Seçilen Ürünü Düzenle";
            duzenle.UseVisualStyleBackColor = true;
            duzenle.Click += duzenle_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(duzenle);
            Controls.Add(silurun);
            Controls.Add(fiyat);
            Controls.Add(button1);
            Controls.Add(ad);
            Controls.Add(stok);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private MaskedTextBox stok;
        private Label label3;
        private TextBox ad;
        private Button button1;
        private MaskedTextBox fiyat;
        private Button silurun;
        private Button duzenle;
        public static ListBox listBox1;
    }
}