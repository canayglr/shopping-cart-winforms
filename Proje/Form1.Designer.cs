namespace Proje
{
    partial class Form1
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
            tumurunler = new ListBox();
            admin = new Button();
            urunlertext = new Label();
            button1 = new Button();
            label1 = new Label();
            sepet = new ListBox();
            sepettencikar = new Button();
            siparisver = new Button();
            toplamtutar = new TextBox();
            label2 = new Label();
            temizle = new Button();
            SuspendLayout();
            // 
            // tumurunler
            // 
            tumurunler.FormattingEnabled = true;
            tumurunler.Location = new Point(28, 50);
            tumurunler.Name = "tumurunler";
            tumurunler.Size = new Size(261, 304);
            tumurunler.TabIndex = 0;
            // 
            // admin
            // 
            admin.Location = new Point(781, -5);
            admin.Name = "admin";
            admin.Size = new Size(125, 29);
            admin.TabIndex = 1;
            admin.Text = "Admin Panel";
            admin.UseVisualStyleBackColor = true;
            admin.Click += admin_Click;
            // 
            // urunlertext
            // 
            urunlertext.AutoSize = true;
            urunlertext.Location = new Point(28, 18);
            urunlertext.Name = "urunlertext";
            urunlertext.Size = new Size(57, 20);
            urunlertext.TabIndex = 2;
            urunlertext.Text = "Ürünler";
            // 
            // button1
            // 
            button1.Location = new Point(28, 381);
            button1.Name = "button1";
            button1.Size = new Size(156, 57);
            button1.TabIndex = 3;
            button1.Text = "Seçili Ürünü Sepete Ekle\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(511, 18);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 5;
            label1.Text = "Sepet";
            // 
            // sepet
            // 
            sepet.FormattingEnabled = true;
            sepet.Location = new Point(511, 41);
            sepet.Name = "sepet";
            sepet.Size = new Size(261, 264);
            sepet.TabIndex = 4;
            // 
            // sepettencikar
            // 
            sepettencikar.Location = new Point(485, 381);
            sepettencikar.Name = "sepettencikar";
            sepettencikar.Size = new Size(156, 57);
            sepettencikar.TabIndex = 6;
            sepettencikar.Text = "Seçili Ürünü Sepetten Çıkar";
            sepettencikar.UseVisualStyleBackColor = true;
            sepettencikar.Click += sepettencikar_Click;
            // 
            // siparisver
            // 
            siparisver.Location = new Point(657, 381);
            siparisver.Name = "siparisver";
            siparisver.Size = new Size(156, 57);
            siparisver.TabIndex = 7;
            siparisver.Text = "Sipariş Ver";
            siparisver.UseVisualStyleBackColor = true;
            siparisver.Click += siparisver_Click;
            // 
            // toplamtutar
            // 
            toplamtutar.BackColor = Color.White;
            toplamtutar.Location = new Point(511, 338);
            toplamtutar.Name = "toplamtutar";
            toplamtutar.ReadOnly = true;
            toplamtutar.Size = new Size(261, 27);
            toplamtutar.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(511, 315);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 9;
            label2.Text = "Toplam Tutar";
            // 
            // temizle
            // 
            temizle.Location = new Point(795, 95);
            temizle.Name = "temizle";
            temizle.Size = new Size(101, 148);
            temizle.TabIndex = 10;
            temizle.Text = "Sepeti Temizle";
            temizle.UseVisualStyleBackColor = true;
            temizle.Click += temizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 450);
            Controls.Add(temizle);
            Controls.Add(label2);
            Controls.Add(toplamtutar);
            Controls.Add(siparisver);
            Controls.Add(sepettencikar);
            Controls.Add(label1);
            Controls.Add(sepet);
            Controls.Add(button1);
            Controls.Add(urunlertext);
            Controls.Add(admin);
            Controls.Add(tumurunler);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button admin;
        private Label urunlertext;
        private Button button1;
        private Label label1;
        private Button sepettencikar;
        private Button siparisver;
        private Label label2;
        private Button temizle;
        public static ListBox tumurunler;
        public static TextBox toplamtutar;
        public static ListBox sepet;
    }
}
