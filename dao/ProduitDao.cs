using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesCom.utils;

namespace GesCom.dao
{
    class ProduitDao : IProduitDao
    {
        Model1Container modelProduit = new Model1Container();

        public Produit getProduitById(int id)
        {
            return modelProduit.Produit.Where(s => s.Id == id).FirstOrDefault();
        }

        
        public int insert(Produit produit)
        {
            modelProduit.Produit.Add(produit);
            return modelProduit.SaveChanges();
        }

        public List<Produit> selectAll()
        {
            return modelProduit.Produit.ToList();
        }
    }
}
