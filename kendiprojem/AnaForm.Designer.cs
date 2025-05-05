namespace kendiprojem
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.btnogrtgiris = new System.Windows.Forms.Button();
            this.btnogrgiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnyardim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnogrtgiris
            // 
            this.btnogrtgiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnogrtgiris.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrtgiris.Location = new System.Drawing.Point(23, 480);
            this.btnogrtgiris.Name = "btnogrtgiris";
            this.btnogrtgiris.Size = new System.Drawing.Size(164, 72);
            this.btnogrtgiris.TabIndex = 3;
            this.btnogrtgiris.Text = "Öğretmen Girişi";
            this.btnogrtgiris.UseVisualStyleBackColor = false;
            this.btnogrtgiris.Click += new System.EventHandler(this.btnogrtgiris_Click);
            // 
            // btnogrgiris
            // 
            this.btnogrgiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnogrgiris.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrgiris.Location = new System.Drawing.Point(681, 480);
            this.btnogrgiris.Name = "btnogrgiris";
            this.btnogrgiris.Size = new System.Drawing.Size(164, 72);
            this.btnogrgiris.TabIndex = 2;
            this.btnogrgiris.Text = "Öğrenci Girişi";
            this.btnogrgiris.UseVisualStyleBackColor = false;
            this.btnogrgiris.Click += new System.EventHandler(this.btnogrgiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOŞ GELDİNİZ";
            // 
            // btnyardim
            // 
            this.btnyardim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnyardim.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyardim.Location = new System.Drawing.Point(681, 21);
            this.btnyardim.Name = "btnyardim";
            this.btnyardim.Size = new System.Drawing.Size(164, 72);
            this.btnyardim.TabIndex = 5;
            this.btnyardim.Text = "Yardım";
            this.btnyardim.UseVisualStyleBackColor = false;
            this.btnyardim.Click += new System.EventHandler(this.btnyardim_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(872, 564);
            this.Controls.Add(this.btnyardim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnogrtgiris);
            this.Controls.Add(this.btnogrgiris);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnogrtgiris;
        private System.Windows.Forms.Button btnogrgiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnyardim;
    }
}