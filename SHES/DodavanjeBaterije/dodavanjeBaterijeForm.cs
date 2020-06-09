using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DodavanjeBaterije
{
    public partial class dodavanjeBaterijeForm : Form
    {
        public dodavanjeBaterijeForm()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BazaPodataka;Integrated Security=True";


        private void dodajBaterijuButton_Click(object sender, EventArgs e)
        {
            if (textBoxIme.Text.Trim().Equals("") || textBoxSnaga.Text.Trim().Equals("") || textBoxKapacitet.Text.Trim().Equals(""))
            {
                MessageBox.Show("Sva polja moraju biti popunjena", "GRESKA", MessageBoxButtons.OK);
                textBoxIme.Text = "";
                textBoxSnaga.Text = "";
                textBoxKapacitet.Text = "";
                textBoxIme.Focus();
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxSnaga.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Pogresan unos snage!", "GRESKA", MessageBoxButtons.OK);
                textBoxSnaga.Text = "";
                textBoxSnaga.Focus();
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxIme.Text, "^[0-9]"))
            {
                MessageBox.Show("Pogresan unos imena!", "GRESKA", MessageBoxButtons.OK);
                textBoxIme.Text = "";
                textBoxIme.Focus();
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxKapacitet.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Pogresan unos snage!", "GRESKA", MessageBoxButtons.OK);
                textBoxKapacitet.Text = "";
                textBoxKapacitet.Focus();
            }

            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string dodavanjePanela = "INSERT INTO Baterija(ime, maxSnaga, kapacitet)VALUES('" + textBoxIme.Text.ToString() + "','" + textBoxSnaga.Text.ToString() + "','" + textBoxKapacitet.Text.ToString() + "')";
                    SqlCommand komandaDodavanje = new SqlCommand(dodavanjePanela, connection);

                    try
                    {
                        komandaDodavanje.ExecuteNonQuery();
                        MessageBox.Show("Uspesno ste dodali bateriju", "Uspesno!", MessageBoxButtons.OK);
                        textBoxIme.Text = "";
                        textBoxSnaga.Text = "";
                        textBoxKapacitet.Text = "";
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nemoguce dodati panel sa tim imenom!", "Greska!", MessageBoxButtons.OK);
                        textBoxIme.Text = "";
                        textBoxSnaga.Text = "";
                        textBoxKapacitet.Text = "";

                    }
                }


            }
        }
    }
}
