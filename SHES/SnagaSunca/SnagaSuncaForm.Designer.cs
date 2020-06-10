namespace SnagaSunca
{
    partial class SnagaSuncaForm
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
            this.textBoxSunce = new System.Windows.Forms.TextBox();
            this.izmeniSunceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snaga sunca:";
            // 
            // textBoxSunce
            // 
            this.textBoxSunce.Location = new System.Drawing.Point(127, 64);
            this.textBoxSunce.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSunce.Name = "textBoxSunce";
            this.textBoxSunce.Size = new System.Drawing.Size(76, 20);
            this.textBoxSunce.TabIndex = 1;
            // 
            // izmeniSunceButton
            // 
            this.izmeniSunceButton.Location = new System.Drawing.Point(146, 124);
            this.izmeniSunceButton.Margin = new System.Windows.Forms.Padding(2);
            this.izmeniSunceButton.Name = "izmeniSunceButton";
            this.izmeniSunceButton.Size = new System.Drawing.Size(80, 28);
            this.izmeniSunceButton.TabIndex = 2;
            this.izmeniSunceButton.Text = "Izmeni";
            this.izmeniSunceButton.UseVisualStyleBackColor = true;
            this.izmeniSunceButton.Click += new System.EventHandler(this.izmeniSunceButton_Click);
            // 
            // SnagaSuncaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 352);
            this.Controls.Add(this.izmeniSunceButton);
            this.Controls.Add(this.textBoxSunce);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SnagaSuncaForm";
            this.Text = "Izmena snage sunca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSunce;
        private System.Windows.Forms.Button izmeniSunceButton;
    }
}

