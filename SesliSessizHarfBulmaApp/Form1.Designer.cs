namespace SesliSessizHarfBulmaApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbkelime = new System.Windows.Forms.TextBox();
            this.rbSesli = new System.Windows.Forms.RadioButton();
            this.rbSessiz = new System.Windows.Forms.RadioButton();
            this.bBul = new System.Windows.Forms.Button();
            this.lSonuc = new System.Windows.Forms.Label();
            this.lKelime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime";
            // 
            // tbkelime
            // 
            this.tbkelime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbkelime.Location = new System.Drawing.Point(86, 24);
            this.tbkelime.Name = "tbkelime";
            this.tbkelime.Size = new System.Drawing.Size(265, 30);
            this.tbkelime.TabIndex = 1;
            this.tbkelime.TextChanged += new System.EventHandler(this.tbkelime_TextChanged);
            // 
            // rbSesli
            // 
            this.rbSesli.AutoSize = true;
            this.rbSesli.Checked = true;
            this.rbSesli.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSesli.Location = new System.Drawing.Point(26, 60);
            this.rbSesli.Name = "rbSesli";
            this.rbSesli.Size = new System.Drawing.Size(57, 23);
            this.rbSesli.TabIndex = 2;
            this.rbSesli.Text = "Sesli";
            this.rbSesli.UseVisualStyleBackColor = true;
            // 
            // rbSessiz
            // 
            this.rbSessiz.AutoSize = true;
            this.rbSessiz.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSessiz.Location = new System.Drawing.Point(89, 60);
            this.rbSessiz.Name = "rbSessiz";
            this.rbSessiz.Size = new System.Drawing.Size(66, 23);
            this.rbSessiz.TabIndex = 3;
            this.rbSessiz.Text = "Sessiz";
            this.rbSessiz.UseVisualStyleBackColor = true;
            // 
            // bBul
            // 
            this.bBul.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBul.Location = new System.Drawing.Point(276, 89);
            this.bBul.Name = "bBul";
            this.bBul.Size = new System.Drawing.Size(75, 31);
            this.bBul.TabIndex = 4;
            this.bBul.Text = "Bul";
            this.bBul.UseVisualStyleBackColor = true;
            this.bBul.Click += new System.EventHandler(this.bBul_Click);
            // 
            // lSonuc
            // 
            this.lSonuc.AutoSize = true;
            this.lSonuc.Location = new System.Drawing.Point(23, 134);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(40, 13);
            this.lSonuc.TabIndex = 5;
            this.lSonuc.Text = "lSonuc";
            // 
            // lKelime
            // 
            this.lKelime.AutoSize = true;
            this.lKelime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKelime.Location = new System.Drawing.Point(370, 31);
            this.lKelime.Name = "lKelime";
            this.lKelime.Size = new System.Drawing.Size(62, 23);
            this.lKelime.TabIndex = 6;
            this.lKelime.Text = "lKelime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lKelime);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.bBul);
            this.Controls.Add(this.rbSessiz);
            this.Controls.Add(this.rbSesli);
            this.Controls.Add(this.tbkelime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SesliSessizApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbkelime;
        private System.Windows.Forms.RadioButton rbSesli;
        private System.Windows.Forms.RadioButton rbSessiz;
        private System.Windows.Forms.Button bBul;
        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.Label lKelime;
    }
}

