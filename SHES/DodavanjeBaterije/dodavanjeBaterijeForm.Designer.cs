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
            this.baterijaDodajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maksimalna snaga:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kapacitet (u satima rada):";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(88, 41);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(167, 22);
            this.textBoxIme.TabIndex = 3;
            // 
            // textBoxSnaga
            // 
            this.textBoxSnaga.Location = new System.Drawing.Point(220, 95);
            this.textBoxSnaga.Name = "textBoxSnaga";
            this.textBoxSnaga.Size = new System.Drawing.Size(167, 22);
            this.textBoxSnaga.TabIndex = 4;
            // 
            // textBoxKapacitet
            // 
            this.textBoxKapacitet.Location = new System.Drawing.Point(274, 147);
            this.textBoxKapacitet.Name = "textBoxKapacitet";
            this.textBoxKapacitet.Size = new System.Drawing.Size(167, 22);
            this.textBoxKapacitet.TabIndex = 5;
            // 
            // baterijaDodajButton
            // 
            this.baterijaDodajButton.Location = new System.Drawing.Point(290, 392);
            this.baterijaDodajButton.Name = "baterijaDodajButton";
            this.baterijaDodajButton.Size = new System.Drawing.Size(118, 35);
            this.baterijaDodajButton.TabIndex = 6;
            this.baterijaDodajButton.Text = "Dodaj";
            this.baterijaDodajButton.UseVisualStyleBackColor = true;
            this.baterijaDodajButton.Click += new System.EventHandler(this.baterijaDodajButton_Click);
            // 
            // dodavanjeBaterijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.baterijaDodajButton);
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
        private System.Windows.Forms.Button baterijaDodajButton;
    }
}

