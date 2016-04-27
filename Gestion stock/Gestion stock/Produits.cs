using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock
{
    public partial class Produits
    {
        public override string ToString()
        {
            return this.id_produits + " " + this.labelle_produits + " " + this.qtestock_produits + " " + this.prixvente_produits + " " + this.description_produits + " " + this.famille_produits; 
        }
    }
}
