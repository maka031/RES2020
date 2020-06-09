using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodavanjePotrosaca
{
    public partial class PotrosacForm : Form
    {
        public PotrosacForm()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BazaPodataka;Integrated Security=True";


        private void dodajPotrosacButton_Click(object sender, EventArgs e)
        {
            if (textBoxIme.Text.Trim().Equals("") || textBoxPotrosnja.Text.Trim().Equals(""))
            {
                MessageBox.Show("Sva polja moraju biti popunjena", "GRESKA", MessageBoxButtons.OK);
                textBoxIme.Text = "";
                textBoxPotrosnja.Text = "";
                textBoxIme.Focus();
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPotrosnja.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("U polju za snagu mozete uneti samo brojeve!", "GRESKA", MessageBoxButtons.OK);
                textBoxPotrosnja.Text = "";
                textBoxPotrosnja.Focus();
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxIme.Text, "^[0-9]"))
            {
                MessageBox.Show("U polju za ime ne mozete uneti brojeve!", "GRESKA", MessageBoxButtons.OK);
                textBoxIme.Text = "";
                textBoxIme.Focus();
            }

            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string dodavanjePanela = "INSERT INTO Potrosac(ime, potrosnja)VALUES('" + textBoxIme.Text.ToString() + "','" + textBoxPotrosnja.Text.ToString() + "')";
                    SqlCommand komandaDodavanje = new SqlCommand(dodavanjePanela, connection);

                    try
                    {
                        komandaDodavanje.ExecuteNonQuery();
                        MessageBox.Show("Uspesno ste dodali panel", "Uspesno!", MessageBoxButtons.OK);
                        textBoxIme.Text = "";
                        textBoxPotrosnja.Text = "";
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nemoguce dodati panel sa tim imenom!", "Greska!", MessageBoxButtons.OK);
                        textBoxIme.Text = "";
                        textBoxPotrosnja.Text = "";

                    }
                }


            }
        }
    }
}
