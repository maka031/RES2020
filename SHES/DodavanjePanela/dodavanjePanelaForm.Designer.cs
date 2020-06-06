namespace DodavanjePanela
{
    partial class dodavanjePanelaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxSnaga = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime panela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maksimalna snaga panela:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(143, 25);
            this.textBoxIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIme.Multiline = true;
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 19);
            this.textBoxIme.TabIndex = 2;
            // 
            // textBoxSnaga
            // 
            this.textBoxSnaga.Location = new System.Drawing.Point(263, 57);
            this.textBoxSnaga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSnaga.Multiline = true;
            this.textBoxSnaga.Name = "textBoxSnaga";
            this.textBoxSnaga.Size = new System.Drawing.Size(100, 19);
            this.textBoxSnaga.TabIndex = 3;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(244, 318);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(84, 37);
            this.dodajButton.TabIndex = 4;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodavanjePanela_Click);
            // 
            // dodavanjePanelaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.textBoxSnaga);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "dodavanjePanelaForm";
            this.Text = "Dodavanje panela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxSnaga;
        private System.Windows.Forms.Button dodajButton;
    }
}

