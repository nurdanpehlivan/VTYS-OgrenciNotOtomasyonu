namespace kendiprojem
{
    partial class Form2cs
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
            this.datagridprogram = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDerslerim = new System.Windows.Forms.TextBox();
            this.btngeriş = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridprogram)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridprogram
            // 
            this.datagridprogram.AllowUserToAddRows = false;
            this.datagridprogram.AllowUserToDeleteRows = false;
            this.datagridprogram.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridprogram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridprogram.Location = new System.Drawing.Point(30, 169);
            this.datagridprogram.Name = "datagridprogram";
            this.datagridprogram.ReadOnly = true;
            this.datagridprogram.RowHeadersWidth = 51;
            this.datagridprogram.RowTemplate.Height = 24;
            this.datagridprogram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridprogram.Size = new System.Drawing.Size(1188, 261);
            this.datagridprogram.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ders Programı";
            // 
            // txtDerslerim
            // 
            this.txtDerslerim.Location = new System.Drawing.Point(30, 105);
            this.txtDerslerim.Margin = new System.Windows.Forms.Padding(4);
            this.txtDerslerim.Name = "txtDerslerim";
            this.txtDerslerim.Size = new System.Drawing.Size(342, 22);
            this.txtDerslerim.TabIndex = 10;
            this.txtDerslerim.TextChanged += new System.EventHandler(this.txtDerslerim_TextChanged);
            // 
            // btngeriş
            // 
            this.btngeriş.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngeriş.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeriş.Location = new System.Drawing.Point(1097, 34);
            this.btngeriş.Name = "btngeriş";
            this.btngeriş.Size = new System.Drawing.Size(121, 40);
            this.btngeriş.TabIndex = 12;
            this.btngeriş.Text = "GERİ";
            this.btngeriş.UseVisualStyleBackColor = false;
            this.btngeriş.Click += new System.EventHandler(this.btngeriş_Click);
            // 
            // Form2cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1259, 452);
            this.Controls.Add(this.btngeriş);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDerslerim);
            this.Controls.Add(this.datagridprogram);
            this.Name = "Form2cs";
            this.Text = "Form2cs";
            this.Load += new System.EventHandler(this.Form2cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridprogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridprogram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDerslerim;
        private System.Windows.Forms.Button btngeriş;
    }
}