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
    public partial class GestionEmployer : Form
    {
        private GESTIONLINQDataContext dc = new GESTIONLINQDataContext();
        public GestionEmployer()
        {
            InitializeComponent();
        }
        private void retour_Click(object sender, EventArgs e)
        {
            Acceuil frm = new Acceuil();
            frm.Show();
            this.Hide();
        }

        private void GestionEmployer_Load(object sender, EventArgs e)
        {
            var lesEmployer = (from prod in dc.Produits select prod).ToList();
            foreach (var prod in lesEmployer)
                listBox1.Items.Add(prod);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
