using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock
{
    public partial class  employer
    {
        public override string ToString()
        {
            return this.id_employer + " " + this.nom_employer + " " + this.prenom_employer;
        }
    }
}
