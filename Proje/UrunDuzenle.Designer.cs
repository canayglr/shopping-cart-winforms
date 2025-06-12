namespace Proje
{
    partial class UrunDuzenle
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
            fiyat = new MaskedTextBox();
            duzenle = new Button();
            ad = new TextBox();
            stok = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // fiyat
            // 
            fiyat.Location = new Point(33, 144);
            fiyat.Mask = "00000";
            fiyat.Name = "fiyat";
            fiyat.Size = new Size(125, 27);
            fiyat.TabIndex = 16;
            fiyat.ValidatingType = typeof(int);
            // 
            // duzenle
            // 
            duzenle.Location = new Point(202, 142);
            duzenle.Name = "duzenle";
            duzenle.Size = new Size(116, 29);
            duzenle.TabIndex = 15;
            duzenle.Text = "Ürün Düzenle";
            duzenle.UseVisualStyleBackColor = true;
            duzenle.Click += duzenle_Click;
            // 
            // ad
            // 
            ad.Location = new Point(33, 60);
            ad.Name = "ad";
            ad.Size = new Size(125, 27);
            ad.TabIndex = 14;
            // 
            // stok
            // 
            stok.Location = new Point(202, 60);
            stok.Mask = "00000";
            stok.Name = "stok";
            stok.Size = new Size(125, 27);
            stok.TabIndex = 13;
            stok.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 37);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 12;
            label3.Text = "Ürün Stoğu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 111);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 11;
            label2.Text = "Ürün Fiyatı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 37);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 10;
            label1.Text = "Ürün Adı";
            // 
            // UrunDuzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 190);
            Controls.Add(fiyat);
            Controls.Add(duzenle);
            Controls.Add(ad);
            Controls.Add(stok);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunDuzenle";
            Text = "UrunDuzenle";
            Load += UrunDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox fiyat;
        private Button duzenle;
        private TextBox ad;
        private MaskedTextBox stok;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}