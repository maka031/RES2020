using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnagaSunca
{
    public partial class SnagaSuncaForm : Form
    {
        public SnagaSuncaForm()
        {
            InitializeComponent();
        }

        public int snagaSunca;

        private void izmeniSunceButton_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxSunce.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Morate uneti broj!", "GRESKA!", MessageBoxButtons.OK);
                textBoxSunce.Text = "";
                textBoxSunce.Focus();
            }
            else if (Int32.Parse(textBoxSunce.Text) < 0)
            {
                MessageBox.Show("Snaga mora biti pozitivan broj!", "GRESKA!", MessageBoxButtons.OK);
                textBoxSunce.Text = "";
                textBoxSunce.Focus();
            }
            else
                snagaSunca = Int32.Parse(textBoxSunce.Text);

        }
    }
}
