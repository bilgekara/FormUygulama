namespace dosyaOkumaForm
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
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxsırala = new System.Windows.Forms.RichTextBox();
            this.buttonGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(72, 52);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(21, 17);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(72, 113);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(21, 17);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(150, 52);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 22);
            this.textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(150, 113);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 22);
            this.textBoxY.TabIndex = 3;
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(333, 71);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(121, 42);
            this.buttonHesapla.TabIndex = 4;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(557, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(146, 150);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sıralama;";
            // 
            // richTextBoxsırala
            // 
            this.richTextBoxsırala.Location = new System.Drawing.Point(103, 273);
            this.richTextBoxsırala.Name = "richTextBoxsırala";
            this.richTextBoxsırala.Size = new System.Drawing.Size(136, 120);
            this.richTextBoxsırala.TabIndex = 7;
            this.richTextBoxsırala.Text = "";
            // 
            // buttonGoster
            // 
            this.buttonGoster.Location = new System.Drawing.Point(570, 245);
            this.buttonGoster.Name = "buttonGoster";
            this.buttonGoster.Size = new System.Drawing.Size(119, 36);
            this.buttonGoster.TabIndex = 8;
            this.buttonGoster.Text = "Göster";
            this.buttonGoster.UseVisualStyleBackColor = true;
            this.buttonGoster.Click += new System.EventHandler(this.buttonGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoster);
            this.Controls.Add(this.richTextBoxsırala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxsırala;
        private System.Windows.Forms.Button buttonGoster;
    }
}

