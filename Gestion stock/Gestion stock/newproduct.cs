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
    public partial class newproduct : Form
    {
        public newproduct()
        {
            InitializeComponent();
        }
        //chaine de connection
        string cs = @"Data Source=SAPHIRA\SQLEXPRESS;Initial Catalog=GestionStock;Integrated Security=True";

        private void Ajout_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("entre les données demander");
                return;
            }

            //création de la connexion sql

            //SqlConnection con = new SqlConnection(cs);
            gestionstkDataContext db = new gestionstkDataContext();
                
                using (SqlConnection maConnexion = new SqlConnection(@"Data Source=SAPHIRA\SQLEXPRESS;Initial Catalog=GestionStock;Integrated Security=True")
                    )
                {
                    SqlCommand maCmd = new SqlCommand("INSERT INTO Produits (labelle_produits, qtestock_produits, prixvente_produits, description_produits, famille_produits) VALUES (@1, @2, @3, @4, @5)", maConnexion);
                    maCmd.Parameters.AddWithValue("@1", textBox1.Text);
                    maCmd.Parameters.AddWithValue("@2", textBox.Text);
                    maCmd.Parameters.AddWithValue("@3", textBox2.Text);
                    maCmd.Parameters.AddWithValue("@4", textBox3.Text);
                    maCmd.Parameters.AddWithValue("@5", textBox4.Text);
                    maConnexion.Open();
                    maCmd.ExecuteNonQuery();
                    
                
            }
            MessageBox.Show("élément ajouté");
        }
    }
}
