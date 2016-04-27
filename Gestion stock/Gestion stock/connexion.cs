using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_stock
{
    public partial class formAcc : Form
    {
        public formAcc()
        {
            InitializeComponent();
        }
        //chaine de connection
        string cs = @"Data Source=ALEXANDRE-PC;Initial Catalog=waveattitudeBDD;Integrated Security=True";
        
        //button valider
        private void valider_Click(object sender, EventArgs e)
        {
            if (logintext.Text=="" || mdptext.Text == "" )
            {
                MessageBox.Show("entrez les données demander");
                return;
            }
            try
            {
                //création de la connexion sql

                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Utilisateur where users_name=@login and mdp_utilisateur=@mdp", con);
                cmd.Parameters.AddWithValue("@login", logintext.Text);
                cmd.Parameters.AddWithValue("@mdp", mdptext.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int compte = ds.Tables[0].Rows.Count;

                //si compte est egale a 1, alors, l'acceuille s'affiche
                if (compte == 1) {
                    MessageBox.Show("Bienvenue");
                    this.Hide();
                    Acceuil acc = new Acceuil();
                    acc.Show();
                }
                else
                {
                    MessageBox.Show("echec de connexion!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NvxEmploye newEmploye = new NvxEmploye();
            newEmploye.Show();
        }
        private void logintext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                mdptext.Focus();
        }

        private void mdptext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
               valider.PerformClick();
        }
    }
}
