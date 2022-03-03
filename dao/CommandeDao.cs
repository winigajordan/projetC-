using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesCom.utils;
using System.Data.Entity;

namespace GesCom.dao
{
    class CommandeDao : ICommandeDao
    {
        Model1Container modelCommande = new Model1Container();

        public int insertCommande(Commande commande)
        {
            //modelCommande.Entry(commande).State = EntityState.Added;
            modelCommande.Commande.Add(commande);
            return modelCommande.SaveChanges();
            

        }
    }
}

/*
 modelCommande.Entry(commande).State = EntityState.Modified;

using (var model = new Model1Container())
            {
                //var blog = new Blog { Name = "ADO.NET Blog" };
                model.Commande.Add(commande);
                return model.SaveChanges();
            }
 */