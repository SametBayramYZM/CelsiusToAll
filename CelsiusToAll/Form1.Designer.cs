
namespace CelsiusToAll
{
    partial class CelsiusToAll
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lbFahrenheit = new System.Windows.Forms.Label();
            this.lbKelvin = new System.Windows.Forms.Label();
            this.lbReaumur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Réaumur :";
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(101, 57);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.Size = new System.Drawing.Size(122, 20);
            this.tbCelsius.TabIndex = 4;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(148, 208);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lbFahrenheit
            // 
            this.lbFahrenheit.AutoSize = true;
            this.lbFahrenheit.Location = new System.Drawing.Point(98, 100);
            this.lbFahrenheit.Name = "lbFahrenheit";
            this.lbFahrenheit.Size = new System.Drawing.Size(0, 13);
            this.lbFahrenheit.TabIndex = 6;
            // 
            // lbKelvin
            // 
            this.lbKelvin.AutoSize = true;
            this.lbKelvin.Location = new System.Drawing.Point(98, 140);
            this.lbKelvin.Name = "lbKelvin";
            this.lbKelvin.Size = new System.Drawing.Size(0, 13);
            this.lbKelvin.TabIndex = 7;
            // 
            // lbReaumur
            // 
            this.lbReaumur.AutoSize = true;
            this.lbReaumur.Location = new System.Drawing.Point(98, 180);
            this.lbReaumur.Name = "lbReaumur";
            this.lbReaumur.Size = new System.Drawing.Size(0, 13);
            this.lbReaumur.TabIndex = 8;
            // 
            // CelsiusToAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 286);
            this.Controls.Add(this.lbReaumur);
            this.Controls.Add(this.lbKelvin);
            this.Controls.Add(this.lbFahrenheit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbCelsius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CelsiusToAll";
            this.Text = "CelsiusToAll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCelsius;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lbFahrenheit;
        private System.Windows.Forms.Label lbKelvin;
        private System.Windows.Forms.Label lbReaumur;
    }
}

