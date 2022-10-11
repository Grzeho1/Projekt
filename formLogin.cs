﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Projekt
{
    public partial class formLogin : Form
    {
        
        public formLogin()
        {

            InitializeComponent();
            
            
        }
        //Připojení k databázi ********************************************
        SqlConnection con = new SqlConnection(@"Data Source=TOMAS;Initial Catalog=Projekt;Integrated Security=True");

        
       
        private void buttonPrihlas_Click(object sender, EventArgs e)
        {
            
           

            String login, heslo;
            login = textBoxLogin.Text;
            heslo = textBoxHeslo.Text;

            try
            {
                String querry = "SELECT * FROM  Login WHERE login = '" + textBoxLogin.Text + "' AND heslo='" + textBoxHeslo.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    login = textBoxLogin.Text;
                    heslo = textBoxHeslo.Text;

                    Uzivatel.Login=login;
                   


                    Form1 nextForm = new Form1();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();



                }
                else
                {
                    MessageBox.Show("Chybné jméno nebo heslo","Chyba",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                }
            }
            catch
            {
                MessageBox.Show("Spojení ztraceno", "Chyba", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            //Připojení k databázi ********************************************

        }




        private void button1_Click(object sender, EventArgs e)
        {
            formRegistrace nextForm = new formRegistrace();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
