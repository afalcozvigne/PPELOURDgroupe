using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_stock
{
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }
        private GESTIONLINQDataContext dc = new GESTIONLINQDataContext();


        private void stock_Load(object sender, EventArgs e)
        {
            var lesProduits = (from prod in dc.Produits select prod).ToList();
            foreach (var prod in lesProduits)
                listBox1.Items.Add(prod);

        }

        private void Addproduct_Click(object sender, EventArgs e)
        {
            int anInteger;
            anInteger = Convert.ToInt32(textBox2.Text);
            anInteger = int.Parse(textBox2.Text);
            double value = double.Parse(textBox3.Text);
            Produits addprod = new Produits
            {

                labelle_produits = textBox1.Text,
                qtestock_produits = anInteger,
                prixvente_produits = value,
                description_produits = textBox4.Text,
                famille_produits = textBox5.Text,
            };
            dc.Produits.InsertOnSubmit(addprod);
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonretoure_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil retourAcc = new Acceuil();
            retourAcc.Show();
        }

        private void delt_Click(object sender, EventArgs e)
        {
            Produits leProduit = listBox1.SelectedItem as Produits;
            var aSup = (from prod in dc.Produits
                        where prod.id_produits == leProduit.id_produits
                        select prod);
            foreach (var prod in aSup)
            {
                dc.Produits.DeleteOnSubmit(prod);
            }

            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            Produits leProduitSel = listBox1.SelectedItem as Produits;
            var aMod = (from prod in dc.Produits
                        where prod.id_produits == leProduitSel.id_produits
                        select prod);
            foreach (var prod in aMod)
            {
                textBox1.Text = prod.labelle_produits;
                textBox2.Text = prod.qtestock_produits.ToString();
                textBox3.Text = prod.prixvente_produits.ToString();
                textBox4.Text = prod.description_produits;
                textBox5.Text = prod.famille_produits;
            }
        }
    }
}


