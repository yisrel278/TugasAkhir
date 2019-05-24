namespace PemesananKopi
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.americano = new System.Windows.Forms.Button();
            this.espresso = new System.Windows.Forms.Button();
            this.cappuccino = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // americano
            // 
            this.americano.AllowDrop = true;
            this.americano.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("americano.BackgroundImage")));
            this.americano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.americano.Location = new System.Drawing.Point(51, 161);
            this.americano.Name = "americano";
            this.americano.Size = new System.Drawing.Size(211, 207);
            this.americano.TabIndex = 0;
            this.americano.UseVisualStyleBackColor = true;
            this.americano.Click += new System.EventHandler(this.americano_Click);
            // 
            // espresso
            // 
            this.espresso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("espresso.BackgroundImage")));
            this.espresso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.espresso.Location = new System.Drawing.Point(287, 162);
            this.espresso.Name = "espresso";
            this.espresso.Size = new System.Drawing.Size(211, 207);
            this.espresso.TabIndex = 1;
            this.espresso.UseVisualStyleBackColor = true;
            this.espresso.Click += new System.EventHandler(this.espresso_Click);
            // 
            // cappuccino
            // 
            this.cappuccino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cappuccino.BackgroundImage")));
            this.cappuccino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cappuccino.Location = new System.Drawing.Point(520, 162);
            this.cappuccino.Name = "cappuccino";
            this.cappuccino.Size = new System.Drawing.Size(211, 207);
            this.cappuccino.TabIndex = 2;
            this.cappuccino.UseVisualStyleBackColor = true;
            this.cappuccino.Click += new System.EventHandler(this.cappuccino_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(124, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Americano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(368, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Espresso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(595, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cappuccino";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(618, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 100);
            this.textBox1.TabIndex = 7;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.submit.Location = new System.Drawing.Point(618, 401);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(172, 33);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.SystemColors.MenuText;
            this.reset.Location = new System.Drawing.Point(13, 401);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(172, 33);
            this.reset.TabIndex = 9;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(802, 446);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cappuccino);
            this.Controls.Add(this.espresso);
            this.Controls.Add(this.americano);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button americano;
        private System.Windows.Forms.Button espresso;
        private System.Windows.Forms.Button cappuccino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button reset;
    }
}

