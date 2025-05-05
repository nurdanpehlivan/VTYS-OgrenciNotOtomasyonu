namespace kendiprojem
{
    partial class OgretmenGirisi
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
            this.btnogrtgiris2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtogrtsif = new System.Windows.Forms.TextBox();
            this.txtogrtad = new System.Windows.Forms.TextBox();
            this.btnogrbas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnogrtgiris2
            // 
            this.btnogrtgiris2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrtgiris2.Location = new System.Drawing.Point(269, 337);
            this.btnogrtgiris2.Name = "btnogrtgiris2";
            this.btnogrtgiris2.Size = new System.Drawing.Size(141, 39);
            this.btnogrtgiris2.TabIndex = 23;
            this.btnogrtgiris2.Text = "Giriş Yap";
            this.btnogrtgiris2.UseVisualStyleBackColor = true;
            this.btnogrtgiris2.Click += new System.EventHandler(this.btnogrtgiris2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(188, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(121, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(174, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Öğretmen Girişi";
            // 
            // txtogrtsif
            // 
            this.txtogrtsif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrtsif.Location = new System.Drawing.Point(246, 256);
            this.txtogrtsif.Name = "txtogrtsif";
            this.txtogrtsif.PasswordChar = '*';
            this.txtogrtsif.Size = new System.Drawing.Size(164, 38);
            this.txtogrtsif.TabIndex = 19;
            // 
            // txtogrtad
            // 
            this.txtogrtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrtad.Location = new System.Drawing.Point(246, 177);
            this.txtogrtad.Name = "txtogrtad";
            this.txtogrtad.Size = new System.Drawing.Size(164, 38);
            this.txtogrtad.TabIndex = 18;
            // 
            // btnogrbas
            // 
            this.btnogrbas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrbas.Location = new System.Drawing.Point(111, 337);
            this.btnogrbas.Name = "btnogrbas";
            this.btnogrbas.Size = new System.Drawing.Size(141, 39);
            this.btnogrbas.TabIndex = 32;
            this.btnogrbas.Text = "Öğrenci";
            this.btnogrbas.UseVisualStyleBackColor = true;
            this.btnogrbas.Click += new System.EventHandler(this.btnogrbas_Click);
            // 
            // OgretmenGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(549, 454);
            this.Controls.Add(this.btnogrbas);
            this.Controls.Add(this.btnogrtgiris2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtogrtsif);
            this.Controls.Add(this.txtogrtad);
            this.Name = "OgretmenGirisi";
            this.Text = "OgretmenGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnogrtgiris2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtogrtsif;
        private System.Windows.Forms.TextBox txtogrtad;
        private System.Windows.Forms.Button btnogrbas;
    }
}