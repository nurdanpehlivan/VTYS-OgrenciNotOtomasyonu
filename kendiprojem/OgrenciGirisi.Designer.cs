namespace kendiprojem
{
    partial class OgrenciGirisi
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
            this.btnogrgiris2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtogrsif = new System.Windows.Forms.TextBox();
            this.txtograd = new System.Windows.Forms.TextBox();
            this.btnogrtbas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnogrgiris2
            // 
            this.btnogrgiris2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrgiris2.Location = new System.Drawing.Point(280, 334);
            this.btnogrgiris2.Name = "btnogrgiris2";
            this.btnogrgiris2.Size = new System.Drawing.Size(141, 39);
            this.btnogrgiris2.TabIndex = 29;
            this.btnogrgiris2.Text = "Giriş Yap";
            this.btnogrgiris2.UseVisualStyleBackColor = true;
            this.btnogrgiris2.Click += new System.EventHandler(this.btnogrgiris2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(199, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(132, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(185, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Öğrenci Girişi";
            // 
            // txtogrsif
            // 
            this.txtogrsif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrsif.Location = new System.Drawing.Point(257, 253);
            this.txtogrsif.Name = "txtogrsif";
            this.txtogrsif.PasswordChar = '*';
            this.txtogrsif.Size = new System.Drawing.Size(164, 38);
            this.txtogrsif.TabIndex = 25;
            // 
            // txtograd
            // 
            this.txtograd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtograd.Location = new System.Drawing.Point(257, 174);
            this.txtograd.Name = "txtograd";
            this.txtograd.Size = new System.Drawing.Size(164, 38);
            this.txtograd.TabIndex = 24;
            // 
            // btnogrtbas
            // 
            this.btnogrtbas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrtbas.Location = new System.Drawing.Point(110, 334);
            this.btnogrtbas.Name = "btnogrtbas";
            this.btnogrtbas.Size = new System.Drawing.Size(141, 39);
            this.btnogrtbas.TabIndex = 31;
            this.btnogrtbas.Text = "Öğretmen";
            this.btnogrtbas.UseVisualStyleBackColor = true;
            this.btnogrtbas.Click += new System.EventHandler(this.btnogrtbas_Click_1);
            // 
            // OgrenciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(534, 462);
            this.Controls.Add(this.btnogrtbas);
            this.Controls.Add(this.btnogrgiris2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtogrsif);
            this.Controls.Add(this.txtograd);
            this.Name = "OgrenciGirisi";
            this.Text = "OgrenciGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnogrgiris2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtogrsif;
        private System.Windows.Forms.TextBox txtograd;
        private System.Windows.Forms.Button btnogrtbas;
    }
}