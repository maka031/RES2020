﻿namespace DodavanjePotrosaca
{
    partial class PotrosacForm
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
            this.naslovLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPotrosnja = new System.Windows.Forms.TextBox();
            this.dodajPotrosacButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // naslovLabel
            // 
            this.naslovLabel.AutoSize = true;
            this.naslovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovLabel.Location = new System.Drawing.Point(12, 9);
            this.naslovLabel.Name = "naslovLabel";
            this.naslovLabel.Size = new System.Drawing.Size(175, 25);
            this.naslovLabel.TabIndex = 0;
            this.naslovLabel.Text = "Dodajte potrosac";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(164, 49);
            this.textBoxIme.Multiline = true;
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(131, 24);
            this.textBoxIme.TabIndex = 3;
            // 
            // textBoxPotrosnja
            // 
            this.textBoxPotrosnja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxPotrosnja.Location = new System.Drawing.Point(164, 90);
            this.textBoxPotrosnja.Multiline = true;
            this.textBoxPotrosnja.Name = "textBoxPotrosnja";
            this.textBoxPotrosnja.Size = new System.Drawing.Size(131, 24);
            this.textBoxPotrosnja.TabIndex = 4;
            // 
            // dodajPotrosacButton
            // 
            this.dodajPotrosacButton.Location = new System.Drawing.Point(176, 144);
            this.dodajPotrosacButton.Name = "dodajPotrosacButton";
            this.dodajPotrosacButton.Size = new System.Drawing.Size(102, 45);
            this.dodajPotrosacButton.TabIndex = 5;
            this.dodajPotrosacButton.Text = "Dodaj";
            this.dodajPotrosacButton.UseVisualStyleBackColor = true;
            this.dodajPotrosacButton.Click += new System.EventHandler(this.dodajPotrosacButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Potrosnja:";
            // 
            // PotrosacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dodajPotrosacButton);
            this.Controls.Add(this.textBoxPotrosnja);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naslovLabel);
            this.Name = "PotrosacForm";
            this.Text = "Dodavanje potrosaca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslovLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPotrosnja;
        private System.Windows.Forms.Button dodajPotrosacButton;
        private System.Windows.Forms.Label label2;
    }
}

