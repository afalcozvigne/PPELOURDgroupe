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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void gestion_Click(object sender, EventArgs e)
        {
            stock stock = new stock();
            stock.Show();
            this.Hide();
        }

        private void ListePerso_Click(object sender, EventArgs e)
        {
            GestionEmployer gestionemployer = new GestionEmployer();
            gestionemployer.Show();
            this.Hide();
        }
    }
}
