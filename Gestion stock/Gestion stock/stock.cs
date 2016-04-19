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
            gestionstkDataContext bdcon = new gestionstkDataContext();
            

        }

        private void stock_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionStockDataSet.Produits'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.produitsTableAdapter.Fill(this.gestionStockDataSet.Produits);

        }

        private void Addproduct_Click(object sender, EventArgs e)
        {
            newproduct addproduct = new newproduct();
            addproduct.Show();
        }

        private void buttonretoure_Click(object sender, EventArgs e)
        {
            
        }
    }
}
