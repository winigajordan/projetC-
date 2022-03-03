using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCom.dto
{
    public class Panier
    {
        
        public string Libelle { get; set; }
        public double Prix { get; set; }
        public int QteCommande { get; set; }
        public Produit ProduitCommande { get; set; }

    }
}
