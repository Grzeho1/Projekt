using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Projekt
{
    public partial class formRegistrace : Form
    {
        public formRegistrace()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=TOMAS;Initial Catalog=Projekt;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            formLogin nextForm = new formLogin();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void tlacitkoRegistruj_Click(object sender, EventArgs e)
        {
            string login, heslo, potvrzeniHesla;

            login = textBoxLogin.Text;
            heslo = textBoxHeslo.Text;
            potvrzeniHesla = textBoxPotvrzeni.Text;
            
            try
            {
                if (login != "" && heslo != "" && heslo==potvrzeniHesla) 
                {

                    String querry = "INSERT INTO  Login VALUES ('" + textBoxLogin.Text + "' ,'" + textBoxHeslo.Text + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    MessageBox.Show("Registrace proběhla uspěšně", ":)", MessageBoxButtons.OK);
                    textBoxHeslo.Clear();
                    textBoxLogin.Clear();
                    textBoxPotvrzeni.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Chyba", "Chyba", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Chyba spojení", "Chyba", MessageBoxButtons.OK);

            }
            finally
            {
                con.Close();

                

            }
        }
    }
}
