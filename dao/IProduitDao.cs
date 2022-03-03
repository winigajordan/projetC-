using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCom.dao
{
    interface IProduitDao
    {
        //Ajout d'un produit
        int insert(Produit produit);

        //Lister les produits
        List<Produit> selectAll();

        //produit by id
        Produit getProduitById(int id);
       
    }
}
