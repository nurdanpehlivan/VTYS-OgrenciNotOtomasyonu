namespace kendiprojem
{
    partial class OgrenciEkrani
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
            this.btnOrtalamaEkranı = new System.Windows.Forms.Button();
            this.btnsinavekranı = new System.Windows.Forms.Button();
            this.btnDersPEkranı = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrtalamaEkranı
            // 
            this.btnOrtalamaEkranı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOrtalamaEkranı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrtalamaEkranı.Location = new System.Drawing.Point(33, 150);
            this.btnOrtalamaEkranı.Name = "btnOrtalamaEkranı";
            this.btnOrtalamaEkranı.Size = new System.Drawing.Size(251, 151);
            this.btnOrtalamaEkranı.TabIndex = 14;
            this.btnOrtalamaEkranı.Text = "NOTLARIM";
            this.btnOrtalamaEkranı.UseVisualStyleBackColor = false;
            this.btnOrtalamaEkranı.Click += new System.EventHandler(this.btnOrtalamaEkranı_Click_1);
            // 
            // btnsinavekranı
            // 
            this.btnsinavekranı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnsinavekranı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsinavekranı.Location = new System.Drawing.Point(347, 150);
            this.btnsinavekranı.Name = "btnsinavekranı";
            this.btnsinavekranı.Size = new System.Drawing.Size(251, 151);
            this.btnsinavekranı.TabIndex = 15;
            this.btnsinavekranı.Text = "SINAVLARIM";
            this.btnsinavekranı.UseVisualStyleBackColor = false;
            this.btnsinavekranı.Click += new System.EventHandler(this.btnsinavekranı_Click);
            // 
            // btnDersPEkranı
            // 
            this.btnDersPEkranı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDersPEkranı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersPEkranı.Location = new System.Drawing.Point(659, 150);
            this.btnDersPEkranı.Name = "btnDersPEkranı";
            this.btnDersPEkranı.Size = new System.Drawing.Size(251, 151);
            this.btnDersPEkranı.TabIndex = 16;
            this.btnDersPEkranı.Text = "DERS PROGRAMI";
            this.btnDersPEkranı.UseVisualStyleBackColor = false;
            this.btnDersPEkranı.Click += new System.EventHandler(this.btnDersPEkranı_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngeri.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.Location = new System.Drawing.Point(789, 29);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(121, 40);
            this.btngeri.TabIndex = 17;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // OgrenciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnDersPEkranı);
            this.Controls.Add(this.btnsinavekranı);
            this.Controls.Add(this.btnOrtalamaEkranı);
            this.Name = "OgrenciEkrani";
            this.Text = "OgrenciEkrani";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrtalamaEkranı;
        private System.Windows.Forms.Button btnsinavekranı;
        private System.Windows.Forms.Button btnDersPEkranı;
        private System.Windows.Forms.Button btngeri;
    }
}