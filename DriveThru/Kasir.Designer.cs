namespace PemesananKopi
{
    partial class Kasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasir));
            this.totalpembelian = new System.Windows.Forms.TextBox();
            this.bayar = new System.Windows.Forms.TextBox();
            this.kembalian = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalpembelian
            // 
            this.totalpembelian.ForeColor = System.Drawing.SystemColors.MenuText;
            this.totalpembelian.Location = new System.Drawing.Point(326, 150);
            this.totalpembelian.Multiline = true;
            this.totalpembelian.Name = "totalpembelian";
            this.totalpembelian.Size = new System.Drawing.Size(349, 84);
            this.totalpembelian.TabIndex = 0;
            // 
            // bayar
            // 
            this.bayar.Location = new System.Drawing.Point(326, 250);
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(349, 20);
            this.bayar.TabIndex = 1;
            this.bayar.TextChanged += new System.EventHandler(this.bayar_TextChanged);
            this.bayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harga_KeyPress);
            // 
            // kembalian
            // 
            this.kembalian.Location = new System.Drawing.Point(326, 298);
            this.kembalian.Name = "kembalian";
            this.kembalian.Size = new System.Drawing.Size(349, 20);
            this.kembalian.TabIndex = 2;
            this.kembalian.TextChanged += new System.EventHandler(this.kembalian_TextChanged);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(600, 373);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(75, 23);
            this.count.TabIndex = 3;
            this.count.Text = "OK";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // Kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(802, 446);
            this.Controls.Add(this.count);
            this.Controls.Add(this.kembalian);
            this.Controls.Add(this.bayar);
            this.Controls.Add(this.totalpembelian);
            this.Name = "Kasir";
            this.Text = "Kasir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalpembelian;
        private System.Windows.Forms.TextBox bayar;
        private System.Windows.Forms.TextBox kembalian;
        private System.Windows.Forms.Button count;
    }
}