namespace kendiprojem
{
    partial class OgrenciForm
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
            this.txtSınavlarım = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridsinav = new System.Windows.Forms.DataGridView();
            this.btngeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridsinav)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSınavlarım
            // 
            this.txtSınavlarım.Location = new System.Drawing.Point(9, 124);
            this.txtSınavlarım.Name = "txtSınavlarım";
            this.txtSınavlarım.Size = new System.Drawing.Size(389, 22);
            this.txtSınavlarım.TabIndex = 5;
            this.txtSınavlarım.TextChanged += new System.EventHandler(this.txtSınavlarım_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 74);
            this.label3.TabIndex = 6;
            this.label3.Text = "SINAVLARIM";
            // 
            // datagridsinav
            // 
            this.datagridsinav.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridsinav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridsinav.Location = new System.Drawing.Point(9, 197);
            this.datagridsinav.Name = "datagridsinav";
            this.datagridsinav.RowHeadersWidth = 51;
            this.datagridsinav.RowTemplate.Height = 24;
            this.datagridsinav.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridsinav.Size = new System.Drawing.Size(1089, 272);
            this.datagridsinav.TabIndex = 7;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngeri.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeri.Location = new System.Drawing.Point(977, 26);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(121, 40);
            this.btngeri.TabIndex = 11;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1124, 574);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.datagridsinav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSınavlarım);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OgrenciForm";
            this.Text = "OgrenciForm";
            this.Load += new System.EventHandler(this.OgrenciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridsinav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSınavlarım;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datagridsinav;
        private System.Windows.Forms.Button btngeri;
    }
}