namespace DodavanjeBaterije
{
    partial class dodavanjeBaterijeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxSnaga = new System.Windows.Forms.TextBox();
            this.textBoxKapacitet = new System.Windows.Forms.TextBox();
            this.dodajBaterijuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kapacitet (u satima rada):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maksimalna snaga:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(86, 37);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(126, 22);
            this.textBoxIme.TabIndex = 3;
            // 
            // textBoxSnaga
            // 
            this.textBoxSnaga.Location = new System.Drawing.Point(218, 86);
            this.textBoxSnaga.Name = "textBoxSnaga";
            this.textBoxSnaga.Size = new System.Drawing.Size(63, 22);
            this.textBoxSnaga.TabIndex = 4;
            // 
            // textBoxKapacitet
            // 
            this.textBoxKapacitet.Location = new System.Drawing.Point(272, 133);
            this.textBoxKapacitet.Name = "textBoxKapacitet";
            this.textBoxKapacitet.Size = new System.Drawing.Size(63, 22);
            this.textBoxKapacitet.TabIndex = 5;
            // 
            // dodajBaterijuButton
            // 
            this.dodajBaterijuButton.Location = new System.Drawing.Point(329, 383);
            this.dodajBaterijuButton.Name = "dodajBaterijuButton";
            this.dodajBaterijuButton.Size = new System.Drawing.Size(115, 38);
            this.dodajBaterijuButton.TabIndex = 6;
            this.dodajBaterijuButton.Text = "Dodaj";
            this.dodajBaterijuButton.UseVisualStyleBackColor = true;
            this.dodajBaterijuButton.Click += new System.EventHandler(this.dodajBaterijuButton_Click);
            // 
            // dodavanjeBaterijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dodajBaterijuButton);
            this.Controls.Add(this.textBoxKapacitet);
            this.Controls.Add(this.textBoxSnaga);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dodavanjeBaterijeForm";
            this.Text = "Dodavanje baterije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxSnaga;
        private System.Windows.Forms.TextBox textBoxKapacitet;
        private System.Windows.Forms.Button dodajBaterijuButton;
    }
}

