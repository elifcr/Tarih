
namespace Tarih
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericGun = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericAy = new System.Windows.Forms.NumericUpDown();
            this.numericYil = new System.Windows.Forms.NumericUpDown();
            this.numericSaniye = new System.Windows.Forms.NumericUpDown();
            this.numericDakika = new System.Windows.Forms.NumericUpDown();
            this.numericSaat = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaniye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericSaniye);
            this.groupBox1.Controls.Add(this.numericDakika);
            this.groupBox1.Controls.Add(this.numericSaat);
            this.groupBox1.Controls.Add(this.numericYil);
            this.groupBox1.Controls.Add(this.numericAy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericGun);
            this.groupBox1.Location = new System.Drawing.Point(33, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih - Saat Ayarla";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericGun
            // 
            this.numericGun.Location = new System.Drawing.Point(74, 50);
            this.numericGun.Name = "numericGun";
            this.numericGun.Size = new System.Drawing.Size(53, 22);
            this.numericGun.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zaman";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericAy
            // 
            this.numericAy.Location = new System.Drawing.Point(143, 50);
            this.numericAy.Name = "numericAy";
            this.numericAy.Size = new System.Drawing.Size(53, 22);
            this.numericAy.TabIndex = 3;
            // 
            // numericYil
            // 
            this.numericYil.Location = new System.Drawing.Point(213, 50);
            this.numericYil.Name = "numericYil";
            this.numericYil.Size = new System.Drawing.Size(62, 22);
            this.numericYil.TabIndex = 4;
            // 
            // numericSaniye
            // 
            this.numericSaniye.Location = new System.Drawing.Point(213, 103);
            this.numericSaniye.Name = "numericSaniye";
            this.numericSaniye.Size = new System.Drawing.Size(62, 22);
            this.numericSaniye.TabIndex = 7;
            // 
            // numericDakika
            // 
            this.numericDakika.Location = new System.Drawing.Point(143, 103);
            this.numericDakika.Name = "numericDakika";
            this.numericDakika.Size = new System.Drawing.Size(53, 22);
            this.numericDakika.TabIndex = 6;
            // 
            // numericSaat
            // 
            this.numericSaat.Location = new System.Drawing.Point(74, 103);
            this.numericSaat.Name = "numericSaat";
            this.numericSaat.Size = new System.Drawing.Size(53, 22);
            this.numericSaat.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Seçilen Değeri Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 343);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaniye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericGun;
        private System.Windows.Forms.NumericUpDown numericSaniye;
        private System.Windows.Forms.NumericUpDown numericDakika;
        private System.Windows.Forms.NumericUpDown numericSaat;
        private System.Windows.Forms.NumericUpDown numericYil;
        private System.Windows.Forms.NumericUpDown numericAy;
        private System.Windows.Forms.Button button1;
    }
}

