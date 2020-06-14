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

namespace DodavanjePanela
{
    public partial class dodavanjePanelaForm : Form
    {
        public dodavanjePanelaForm()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BazaPodataka;Integrated Security=True";

        private void dodavanjePanela_Click(object sender, EventArgs e)
        {
            if(textBoxIme.Text.Trim().Equals("") || textBoxSnaga.Text.Trim().Equals(""))
            {
                MessageBox.Show("Sva polja moraju biti popunjena", "GRESKA", MessageBoxButtons.OK);
                textBoxIme.Text = "";
                textBoxSnaga.Text = "";
                textBoxIme.Focus();
            }
            else if(System.Text.RegularExpressions.Regex.IsMatch(textBoxSnaga.Text, "^[a-zA-Z]"))
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
            else if (Int32.Parse(textBoxSnaga.Text) < 0)
            {
                MessageBox.Show("Snaga mora biti pozitivan broj!", "GRESKA!", MessageBoxButtons.OK);
                textBoxSnaga.Text = "";
                textBoxSnaga.Focus();
            }

            else
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string dodavanjePanela = "INSERT INTO Panel(ime, maxSnaga)VALUES('" + textBoxIme.Text.ToString() + "','" + textBoxSnaga.Text.ToString() + "')";
                    SqlCommand komandaDodavanje = new SqlCommand(dodavanjePanela, connection);

                    try
                    {
                        komandaDodavanje.ExecuteNonQuery();
                        sqlre
                        MessageBox.Show("Uspesno ste dodali panel", "Uspesno!", MessageBoxButtons.OK);
                        textBoxIme.Text = "";
                        textBoxSnaga.Text = "";
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nemoguce dodati panel sa tim imenom!", "Greska!", MessageBoxButtons.OK);
                        textBoxIme.Text = "";
                        textBoxSnaga.Text = "";
                        
                    }
                }

                
            }
        }
    }
}
