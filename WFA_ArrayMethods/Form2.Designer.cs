namespace WFA_ArrayMethods
{
    partial class Form2
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
            this.lstKayitliElemanlar = new System.Windows.Forms.ListBox();
            this.btnElemanEkle = new System.Windows.Forms.Button();
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.btnOrnek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKayitliElemanlar
            // 
            this.lstKayitliElemanlar.FormattingEnabled = true;
            this.lstKayitliElemanlar.Location = new System.Drawing.Point(12, 121);
            this.lstKayitliElemanlar.Name = "lstKayitliElemanlar";
            this.lstKayitliElemanlar.Size = new System.Drawing.Size(199, 134);
            this.lstKayitliElemanlar.TabIndex = 15;
            // 
            // btnElemanEkle
            // 
            this.btnElemanEkle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElemanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElemanEkle.ForeColor = System.Drawing.Color.White;
            this.btnElemanEkle.Location = new System.Drawing.Point(12, 78);
            this.btnElemanEkle.Name = "btnElemanEkle";
            this.btnElemanEkle.Size = new System.Drawing.Size(199, 40);
            this.btnElemanEkle.TabIndex = 14;
            this.btnElemanEkle.Text = "ELEMAN EKLE";
            this.btnElemanEkle.UseVisualStyleBackColor = false;
            this.btnElemanEkle.Click += new System.EventHandler(this.btnElemanEkle_Click);
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(12, 55);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(199, 20);
            this.txtGirisAlani.TabIndex = 13;
            // 
            // btnOrnek
            // 
            this.btnOrnek.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrnek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrnek.ForeColor = System.Drawing.Color.White;
            this.btnOrnek.Location = new System.Drawing.Point(12, 12);
            this.btnOrnek.Name = "btnOrnek";
            this.btnOrnek.Size = new System.Drawing.Size(199, 40);
            this.btnOrnek.TabIndex = 12;
            this.btnOrnek.Text = "ÖRNEK";
            this.btnOrnek.UseVisualStyleBackColor = false;
            this.btnOrnek.Click += new System.EventHandler(this.btnOrnek_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 269);
            this.Controls.Add(this.lstKayitliElemanlar);
            this.Controls.Add(this.btnElemanEkle);
            this.Controls.Add(this.txtGirisAlani);
            this.Controls.Add(this.btnOrnek);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKayitliElemanlar;
        private System.Windows.Forms.Button btnElemanEkle;
        private System.Windows.Forms.TextBox txtGirisAlani;
        private System.Windows.Forms.Button btnOrnek;
    }
}